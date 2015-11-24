namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nombreCompleto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.genero1 = new System.Windows.Forms.RadioButton();
            this.genero2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.estrato = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.desempleado = new System.Windows.Forms.CheckBox();
            this.enviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre completo: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nombreCompleto
            // 
            this.nombreCompleto.Location = new System.Drawing.Point(116, 13);
            this.nombreCompleto.Name = "nombreCompleto";
            this.nombreCompleto.Size = new System.Drawing.Size(258, 20);
            this.nombreCompleto.TabIndex = 1;
            this.nombreCompleto.TextChanged += new System.EventHandler(this.nombreCompleto_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genero:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // genero1
            // 
            this.genero1.AutoSize = true;
            this.genero1.Location = new System.Drawing.Point(80, 47);
            this.genero1.Name = "genero1";
            this.genero1.Size = new System.Drawing.Size(73, 17);
            this.genero1.TabIndex = 3;
            this.genero1.TabStop = true;
            this.genero1.Text = "Masculino";
            this.genero1.UseVisualStyleBackColor = true;
            this.genero1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // genero2
            // 
            this.genero2.AutoSize = true;
            this.genero2.Location = new System.Drawing.Point(172, 47);
            this.genero2.Name = "genero2";
            this.genero2.Size = new System.Drawing.Size(71, 17);
            this.genero2.TabIndex = 4;
            this.genero2.TabStop = true;
            this.genero2.Text = "Femenino";
            this.genero2.UseVisualStyleBackColor = true;
            this.genero2.CheckedChanged += new System.EventHandler(this.genero2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estrato:";
            // 
            // estrato
            // 
            this.estrato.FormattingEnabled = true;
            this.estrato.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.estrato.Location = new System.Drawing.Point(80, 83);
            this.estrato.Name = "estrato";
            this.estrato.Size = new System.Drawing.Size(42, 21);
            this.estrato.TabIndex = 6;
            this.estrato.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de nacimiento";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.Location = new System.Drawing.Point(145, 125);
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.fechaNacimiento.TabIndex = 8;
            // 
            // desempleado
            // 
            this.desempleado.AutoSize = true;
            this.desempleado.Location = new System.Drawing.Point(19, 165);
            this.desempleado.Name = "desempleado";
            this.desempleado.Size = new System.Drawing.Size(91, 17);
            this.desempleado.TabIndex = 9;
            this.desempleado.Text = "Desempleado";
            this.desempleado.UseVisualStyleBackColor = true;
            this.desempleado.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // enviar
            // 
            this.enviar.Location = new System.Drawing.Point(167, 218);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(75, 23);
            this.enviar.TabIndex = 10;
            this.enviar.Text = "Enviar";
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 261);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.desempleado);
            this.Controls.Add(this.fechaNacimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.estrato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.genero2);
            this.Controls.Add(this.genero1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombreCompleto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Encuesta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreCompleto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton genero1;
        private System.Windows.Forms.RadioButton genero2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox estrato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fechaNacimiento;
        private System.Windows.Forms.CheckBox desempleado;
        private System.Windows.Forms.Button enviar;
    }
}

