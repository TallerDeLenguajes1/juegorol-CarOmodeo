
namespace JuegoRol
{
    partial class FormCrearPersonaje
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
            this.nombre = new System.Windows.Forms.TextBox();
            this.apodo = new System.Windows.Forms.TextBox();
            this.tipoPersonaje = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelTipoPersonaje = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApodo = new System.Windows.Forms.Label();
            this.labelFechaNac = new System.Windows.Forms.Label();
            this.groupPersonaje = new System.Windows.Forms.GroupBox();
            this.groupPersonaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(136, 100);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(205, 20);
            this.nombre.TabIndex = 0;
            // 
            // apodo
            // 
            this.apodo.Location = new System.Drawing.Point(136, 137);
            this.apodo.Name = "apodo";
            this.apodo.Size = new System.Drawing.Size(205, 20);
            this.apodo.TabIndex = 1;
            // 
            // tipoPersonaje
            // 
            this.tipoPersonaje.FormattingEnabled = true;
            this.tipoPersonaje.Location = new System.Drawing.Point(127, 51);
            this.tipoPersonaje.Name = "tipoPersonaje";
            this.tipoPersonaje.Size = new System.Drawing.Size(205, 21);
            this.tipoPersonaje.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 170);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(205, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2021, 6, 3, 0, 0, 0, 0);
            // 
            // labelTipoPersonaje
            // 
            this.labelTipoPersonaje.AutoSize = true;
            this.labelTipoPersonaje.Location = new System.Drawing.Point(46, 66);
            this.labelTipoPersonaje.Name = "labelTipoPersonaje";
            this.labelTipoPersonaje.Size = new System.Drawing.Size(28, 13);
            this.labelTipoPersonaje.TabIndex = 4;
            this.labelTipoPersonaje.Text = "Tipo";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(46, 103);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 5;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApodo
            // 
            this.labelApodo.AutoSize = true;
            this.labelApodo.Location = new System.Drawing.Point(46, 144);
            this.labelApodo.Name = "labelApodo";
            this.labelApodo.Size = new System.Drawing.Size(38, 13);
            this.labelApodo.TabIndex = 6;
            this.labelApodo.Text = "Apodo";
            // 
            // labelFechaNac
            // 
            this.labelFechaNac.AutoSize = true;
            this.labelFechaNac.Location = new System.Drawing.Point(46, 176);
            this.labelFechaNac.Name = "labelFechaNac";
            this.labelFechaNac.Size = new System.Drawing.Size(81, 13);
            this.labelFechaNac.TabIndex = 7;
            this.labelFechaNac.Text = "Fec Nacimiento";
            // 
            // groupPersonaje
            // 
            this.groupPersonaje.Controls.Add(this.tipoPersonaje);
            this.groupPersonaje.Location = new System.Drawing.Point(9, 12);
            this.groupPersonaje.Name = "groupPersonaje";
            this.groupPersonaje.Size = new System.Drawing.Size(779, 426);
            this.groupPersonaje.TabIndex = 8;
            this.groupPersonaje.TabStop = false;
            this.groupPersonaje.Text = "Crear Personaje";
            // 
            // FormCrearPersonaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 450);
            this.Controls.Add(this.labelFechaNac);
            this.Controls.Add(this.labelApodo);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelTipoPersonaje);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.apodo);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.groupPersonaje);
            this.Name = "FormCrearPersonaje";
            this.Text = "Personajes";
            this.groupPersonaje.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apodo;
        private System.Windows.Forms.ComboBox tipoPersonaje;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelTipoPersonaje;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApodo;
        private System.Windows.Forms.Label labelFechaNac;
        private System.Windows.Forms.GroupBox groupPersonaje;
    }
}

