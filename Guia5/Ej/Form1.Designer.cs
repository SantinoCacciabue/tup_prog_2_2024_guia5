namespace Ej
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bIniciar = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.tBnombre = new System.Windows.Forms.TextBox();
            this.tBdir = new System.Windows.Forms.TextBox();
            this.cBcodigo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tBprecio = new System.Windows.Forms.TextBox();
            this.tBancho = new System.Windows.Forms.TextBox();
            this.tBcodigo = new System.Windows.Forms.TextBox();
            this.tBlargo = new System.Windows.Forms.TextBox();
            this.tBgrosor = new System.Windows.Forms.TextBox();
            this.bAgregar = new System.Windows.Forms.Button();
            this.rBmesa = new System.Windows.Forms.RadioButton();
            this.rBbanco = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBcodigo);
            this.groupBox1.Controls.Add(this.tBdir);
            this.groupBox1.Controls.Add(this.tBnombre);
            this.groupBox1.Controls.Add(this.bCerrar);
            this.groupBox1.Controls.Add(this.bBorrar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bIniciar);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rBbanco);
            this.groupBox2.Controls.Add(this.rBmesa);
            this.groupBox2.Controls.Add(this.bAgregar);
            this.groupBox2.Controls.Add(this.tBgrosor);
            this.groupBox2.Controls.Add(this.tBlargo);
            this.groupBox2.Controls.Add(this.tBcodigo);
            this.groupBox2.Controls.Add(this.tBancho);
            this.groupBox2.Controls.Add(this.tBprecio);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(247, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 181);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección:";
            // 
            // bIniciar
            // 
            this.bIniciar.Location = new System.Drawing.Point(21, 87);
            this.bIniciar.Name = "bIniciar";
            this.bIniciar.Size = new System.Drawing.Size(75, 38);
            this.bIniciar.TabIndex = 2;
            this.bIniciar.Text = "Iniciar pedido";
            this.bIniciar.UseVisualStyleBackColor = true;
            this.bIniciar.Click += new System.EventHandler(this.bIniciar_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(105, 87);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 38);
            this.bCerrar.TabIndex = 3;
            this.bCerrar.Text = "Cerrar pedido";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.Location = new System.Drawing.Point(129, 148);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(75, 23);
            this.bBorrar.TabIndex = 4;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // tBnombre
            // 
            this.tBnombre.Location = new System.Drawing.Point(71, 25);
            this.tBnombre.Name = "tBnombre";
            this.tBnombre.Size = new System.Drawing.Size(100, 20);
            this.tBnombre.TabIndex = 5;
            // 
            // tBdir
            // 
            this.tBdir.Location = new System.Drawing.Point(71, 51);
            this.tBdir.Name = "tBdir";
            this.tBdir.Size = new System.Drawing.Size(100, 20);
            this.tBdir.TabIndex = 6;
            // 
            // cBcodigo
            // 
            this.cBcodigo.FormattingEnabled = true;
            this.cBcodigo.Location = new System.Drawing.Point(13, 148);
            this.cBcodigo.Name = "cBcodigo";
            this.cBcodigo.Size = new System.Drawing.Size(110, 21);
            this.cBcodigo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio base:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ancho:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Código:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Largo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Grosor:";
            // 
            // tBprecio
            // 
            this.tBprecio.Location = new System.Drawing.Point(71, 29);
            this.tBprecio.Name = "tBprecio";
            this.tBprecio.Size = new System.Drawing.Size(66, 20);
            this.tBprecio.TabIndex = 8;
            // 
            // tBancho
            // 
            this.tBancho.Location = new System.Drawing.Point(71, 54);
            this.tBancho.Name = "tBancho";
            this.tBancho.Size = new System.Drawing.Size(66, 20);
            this.tBancho.TabIndex = 13;
            // 
            // tBcodigo
            // 
            this.tBcodigo.Location = new System.Drawing.Point(71, 80);
            this.tBcodigo.Name = "tBcodigo";
            this.tBcodigo.Size = new System.Drawing.Size(66, 20);
            this.tBcodigo.TabIndex = 14;
            // 
            // tBlargo
            // 
            this.tBlargo.Location = new System.Drawing.Point(186, 29);
            this.tBlargo.Name = "tBlargo";
            this.tBlargo.Size = new System.Drawing.Size(66, 20);
            this.tBlargo.TabIndex = 15;
            // 
            // tBgrosor
            // 
            this.tBgrosor.Location = new System.Drawing.Point(186, 56);
            this.tBgrosor.Name = "tBgrosor";
            this.tBgrosor.Size = new System.Drawing.Size(66, 20);
            this.tBgrosor.TabIndex = 16;
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(177, 87);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(75, 38);
            this.bAgregar.TabIndex = 8;
            this.bAgregar.Text = "Agregar producto";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // rBmesa
            // 
            this.rBmesa.AutoSize = true;
            this.rBmesa.Location = new System.Drawing.Point(34, 128);
            this.rBmesa.Name = "rBmesa";
            this.rBmesa.Size = new System.Drawing.Size(51, 17);
            this.rBmesa.TabIndex = 17;
            this.rBmesa.TabStop = true;
            this.rBmesa.Text = "Mesa";
            this.rBmesa.UseVisualStyleBackColor = true;
            this.rBmesa.CheckedChanged += new System.EventHandler(this.rBmesa_CheckedChanged);
            // 
            // rBbanco
            // 
            this.rBbanco.AutoSize = true;
            this.rBbanco.Location = new System.Drawing.Point(34, 148);
            this.rBbanco.Name = "rBbanco";
            this.rBbanco.Size = new System.Drawing.Size(56, 17);
            this.rBbanco.TabIndex = 18;
            this.rBbanco.TabStop = true;
            this.rBbanco.Text = "Banco";
            this.rBbanco.UseVisualStyleBackColor = true;
            this.rBbanco.CheckedChanged += new System.EventHandler(this.rBbanco_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 211);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bIniciar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.TextBox tBdir;
        private System.Windows.Forms.TextBox tBnombre;
        private System.Windows.Forms.ComboBox cBcodigo;
        private System.Windows.Forms.RadioButton rBbanco;
        private System.Windows.Forms.RadioButton rBmesa;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.TextBox tBgrosor;
        private System.Windows.Forms.TextBox tBlargo;
        private System.Windows.Forms.TextBox tBcodigo;
        private System.Windows.Forms.TextBox tBancho;
        private System.Windows.Forms.TextBox tBprecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

