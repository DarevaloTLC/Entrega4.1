#include <stdio.h>
#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>

int main(int argc, char *argv[])
{
	
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	char peticion[512];
	char respuesta[512];
	
	//Iniciaciones
	//Abrimos el socket...
	
	if((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creando el socket");
	//Bind al puerto
	
	memset(&serv_adr, 0, sizeof(serv_adr));
	serv_adr.sin_family = AF_INET;
	
	//Asocia el socket a cualquiera de las IP de la maquina.
	//htonl formatea el numero que recibe al formato necesario.
	
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	//Escucharemos en el puerto 9050.
	serv_adr.sin_port = htons(9050);
	
	if(bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf("Error al bind");
	if(listen(sock_listen, 3) < 0)
		printf("Error en el Listen");
	int i;
	
	for (i=0;i<5;i++)
	{
		printf("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf("He recibido conexion\n");
		
		//Bucle de atención al cliente
		int terminar = 0;
		while(terminar == 0)
		{
			//Al servidor le llega un mensaje del tipo  1/23 - el uno significa que quiere pasar de grados celsius a farenheit el 2 lo contrario
			ret=read(sock_conn,peticion, sizeof(peticion));
			printf("Recibido\n");
			
			//RET es el numero de bytes que he leido...
			
			//Tenemos que añadirle la marca de fin de string para que no escriba lo que hay despues en el buffer
			
			peticion[ret]='\0';
			
			//Escribimos en nombre en la consola
			
			printf("Peticion: %s\n", peticion);
			
			char *p = strtok(peticion, "/");
			int codigo = atoi (p); //atoi convierte a numero entero
			
			
			
				
			if(codigo == 0)
			{
				printf("Cerrando conexion\n");
				terminar=1;
			}
			else if (codigo == 1)
			{
				p = strtok(NULL, "/"); //formula para pasar de celsius a farenheit
				float celsius = atof(p);
				float faren = (celsius * 9/5) +32;
				
				sprintf(respuesta, "%.2f", faren);	
				
				
				printf ("Codigo: %d, Numero: %.2f\n", codigo, faren);
				
			}
			else if (codigo == 2) //pasar de farenheit a celsius
			{
				p = strtok(NULL, "/"); //formula para pasar de farenheit a celsius
				float faren = atof(p);
				float celsius = (faren - 32) * 5/9;
				sprintf(respuesta, "%.2f", celsius);
				
				printf ("Codigo: %d, Numero: %.2f\n", codigo, celsius);
			
				
			}
			
			
			
			
			
			if (codigo != 0)
			{
				printf("Respuesta: %s\n", respuesta);
				
				write(sock_conn, respuesta, strlen(respuesta));
			}
		}
		close(sock_conn);
		
		
		
	}
	
}
