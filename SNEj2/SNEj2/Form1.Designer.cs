namespace SNEj2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grados = new System.Windows.Forms.Label();
            this.gradostext = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cod2 = new System.Windows.Forms.RadioButton();
            this.cod1 = new System.Windows.Forms.RadioButton();
            this.enviar = new System.Windows.Forms.Button();
            this.conectar = new System.Windows.Forms.Button();
            this.desconectar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grados
            // 
            this.grados.AutoSize = true;
            this.grados.Location = new System.Drawing.Point(27, 41);
            this.grados.Name = "grados";
            this.grados.Size = new System.Drawing.Size(68, 16);
            this.grados.TabIndex = 0;
            this.grados.Text = "GRADOS:";
            // 
            // gradostext
            // 
            this.gradostext.Location = new System.Drawing.Point(101, 38);
            this.gradostext.Name = "gradostext";
            this.gradostext.Size = new System.Drawing.Size(67, 22);
            this.gradostext.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.cod2);
            this.groupBox1.Controls.Add(this.cod1);
            this.groupBox1.Controls.Add(this.enviar);
            this.groupBox1.Controls.Add(this.grados);
            this.groupBox1.Controls.Add(this.gradostext);
            this.groupBox1.Location = new System.Drawing.Point(28, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 354);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cod2
            // 
            this.cod2.AutoSize = true;
            this.cod2.Location = new System.Drawing.Point(101, 134);
            this.cod2.Name = "cod2";
            this.cod2.Size = new System.Drawing.Size(132, 20);
            this.cod2.TabIndex = 4;
            this.cod2.TabStop = true;
            this.cod2.Text = "Farenheit-Celsius";
            this.cod2.UseVisualStyleBackColor = true;
            // 
            // cod1
            // 
            this.cod1.AutoSize = true;
            this.cod1.Location = new System.Drawing.Point(101, 90);
            this.cod1.Name = "cod1";
            this.cod1.Size = new System.Drawing.Size(132, 20);
            this.cod1.TabIndex = 3;
            this.cod1.TabStop = true;
            this.cod1.Text = "Celsius-Farenheit";
            this.cod1.UseVisualStyleBackColor = true;
            // 
            // enviar
            // 
            this.enviar.Location = new System.Drawing.Point(30, 306);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(75, 23);
            this.enviar.TabIndex = 2;
            this.enviar.Text = "Enviar";
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // conectar
            // 
            this.conectar.Location = new System.Drawing.Point(582, 40);
            this.conectar.Name = "conectar";
            this.conectar.Size = new System.Drawing.Size(125, 44);
            this.conectar.TabIndex = 2;
            this.conectar.Text = "CONECTAR";
            this.conectar.UseVisualStyleBackColor = true;
            this.conectar.Click += new System.EventHandler(this.conectar_Click);
            // 
            // desconectar
            // 
            this.desconectar.Location = new System.Drawing.Point(582, 133);
            this.desconectar.Name = "desconectar";
            this.desconectar.Size = new System.Drawing.Size(125, 45);
            this.desconectar.TabIndex = 3;
            this.desconectar.Text = "DESCONECTAR";
            this.desconectar.UseVisualStyleBackColor = true;
            this.desconectar.Click += new System.EventHandler(this.desconectar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.conectar);
            this.Controls.Add(this.desconectar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label grados;
        private System.Windows.Forms.TextBox gradostext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cod2;
        private System.Windows.Forms.RadioButton cod1;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.Button conectar;
        private System.Windows.Forms.Button desconectar;
    }
}

