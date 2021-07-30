
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
            this.btnCrearNuevoPerd = new System.Windows.Forms.Button();
            this.btnPersAleatorio = new System.Windows.Forms.Button();
            this.btnCrearEnemgos = new System.Windows.Forms.Button();
            this.groupDatos = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelArm = new System.Windows.Forms.Label();
            this.labelNivel = new System.Windows.Forms.Label();
            this.labelFuerza = new System.Windows.Forms.Label();
            this.labelDes = new System.Windows.Forms.Label();
            this.labelVel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSalud = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelFechNac = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxPersonajes = new System.Windows.Forms.ComboBox();
            this.btnIrBatalla = new System.Windows.Forms.Button();
            this.btnGuardarListaPersj = new System.Windows.Forms.Button();
            this.groupPersonaje.SuspendLayout();
            this.groupDatos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(122, 114);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(205, 20);
            this.nombre.TabIndex = 0;
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // apodo
            // 
            this.apodo.Location = new System.Drawing.Point(122, 161);
            this.apodo.Name = "apodo";
            this.apodo.Size = new System.Drawing.Size(205, 20);
            this.apodo.TabIndex = 1;
            this.apodo.TextChanged += new System.EventHandler(this.apodo_TextChanged);
            // 
            // tipoPersonaje
            // 
            this.tipoPersonaje.FormattingEnabled = true;
            this.tipoPersonaje.Location = new System.Drawing.Point(122, 52);
            this.tipoPersonaje.Name = "tipoPersonaje";
            this.tipoPersonaje.Size = new System.Drawing.Size(205, 21);
            this.tipoPersonaje.TabIndex = 2;
            this.tipoPersonaje.SelectedIndexChanged += new System.EventHandler(this.tipoPersonaje_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 221);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(205, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2021, 6, 3, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelTipoPersonaje
            // 
            this.labelTipoPersonaje.AutoSize = true;
            this.labelTipoPersonaje.Location = new System.Drawing.Point(32, 55);
            this.labelTipoPersonaje.Name = "labelTipoPersonaje";
            this.labelTipoPersonaje.Size = new System.Drawing.Size(28, 13);
            this.labelTipoPersonaje.TabIndex = 4;
            this.labelTipoPersonaje.Text = "Tipo";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(32, 117);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 5;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApodo
            // 
            this.labelApodo.AutoSize = true;
            this.labelApodo.Location = new System.Drawing.Point(32, 168);
            this.labelApodo.Name = "labelApodo";
            this.labelApodo.Size = new System.Drawing.Size(38, 13);
            this.labelApodo.TabIndex = 6;
            this.labelApodo.Text = "Apodo";
            // 
            // labelFechaNac
            // 
            this.labelFechaNac.AutoSize = true;
            this.labelFechaNac.Location = new System.Drawing.Point(32, 227);
            this.labelFechaNac.Name = "labelFechaNac";
            this.labelFechaNac.Size = new System.Drawing.Size(81, 13);
            this.labelFechaNac.TabIndex = 7;
            this.labelFechaNac.Text = "Fec Nacimiento";
            // 
            // groupPersonaje
            // 
            this.groupPersonaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupPersonaje.Controls.Add(this.btnCrearNuevoPerd);
            this.groupPersonaje.Controls.Add(this.btnPersAleatorio);
            this.groupPersonaje.Controls.Add(this.tipoPersonaje);
            this.groupPersonaje.Controls.Add(this.labelFechaNac);
            this.groupPersonaje.Controls.Add(this.labelTipoPersonaje);
            this.groupPersonaje.Controls.Add(this.labelNombre);
            this.groupPersonaje.Controls.Add(this.labelApodo);
            this.groupPersonaje.Controls.Add(this.nombre);
            this.groupPersonaje.Controls.Add(this.dateTimePicker1);
            this.groupPersonaje.Controls.Add(this.apodo);
            this.groupPersonaje.Location = new System.Drawing.Point(9, 12);
            this.groupPersonaje.Name = "groupPersonaje";
            this.groupPersonaje.Size = new System.Drawing.Size(360, 373);
            this.groupPersonaje.TabIndex = 8;
            this.groupPersonaje.TabStop = false;
            this.groupPersonaje.Text = "Crear Personaje";
            // 
            // btnCrearNuevoPerd
            // 
            this.btnCrearNuevoPerd.Enabled = false;
            this.btnCrearNuevoPerd.Location = new System.Drawing.Point(230, 296);
            this.btnCrearNuevoPerd.Name = "btnCrearNuevoPerd";
            this.btnCrearNuevoPerd.Size = new System.Drawing.Size(111, 41);
            this.btnCrearNuevoPerd.TabIndex = 4;
            this.btnCrearNuevoPerd.Text = "Crear Nuevo Personaje";
            this.btnCrearNuevoPerd.UseVisualStyleBackColor = true;
            this.btnCrearNuevoPerd.Click += new System.EventHandler(this.btnCrearNuevoPerd_Click);
            // 
            // btnPersAleatorio
            // 
            this.btnPersAleatorio.Location = new System.Drawing.Point(94, 296);
            this.btnPersAleatorio.Name = "btnPersAleatorio";
            this.btnPersAleatorio.Size = new System.Drawing.Size(121, 41);
            this.btnPersAleatorio.TabIndex = 3;
            this.btnPersAleatorio.Text = "Crear Personaje Aleatorio";
            this.btnPersAleatorio.UseVisualStyleBackColor = true;
            this.btnPersAleatorio.Click += new System.EventHandler(this.btnPersAleatorio_Click);
            // 
            // btnCrearEnemgos
            // 
            this.btnCrearEnemgos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCrearEnemgos.Location = new System.Drawing.Point(603, 403);
            this.btnCrearEnemgos.Name = "btnCrearEnemgos";
            this.btnCrearEnemgos.Size = new System.Drawing.Size(113, 39);
            this.btnCrearEnemgos.TabIndex = 9;
            this.btnCrearEnemgos.Text = "Crear Enemigos";
            this.btnCrearEnemgos.UseVisualStyleBackColor = true;
            this.btnCrearEnemgos.Click += new System.EventHandler(this.btnCrearEnemigos_Click);
            // 
            // groupDatos
            // 
            this.groupDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupDatos.Controls.Add(this.groupBox2);
            this.groupDatos.Controls.Add(this.groupBox1);
            this.groupDatos.Controls.Add(this.comboBoxPersonajes);
            this.groupDatos.Location = new System.Drawing.Point(375, 12);
            this.groupDatos.Name = "groupDatos";
            this.groupDatos.Size = new System.Drawing.Size(468, 373);
            this.groupDatos.TabIndex = 10;
            this.groupDatos.TabStop = false;
            this.groupDatos.Text = "Datos Personajes";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.labelArm);
            this.groupBox2.Controls.Add(this.labelNivel);
            this.groupBox2.Controls.Add(this.labelFuerza);
            this.groupBox2.Controls.Add(this.labelDes);
            this.groupBox2.Controls.Add(this.labelVel);
            this.groupBox2.Location = new System.Drawing.Point(256, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 310);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Caracteristicas";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(91, 236);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 13);
            this.label16.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(91, 189);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(91, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(91, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(91, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 7;
            // 
            // labelArm
            // 
            this.labelArm.AutoSize = true;
            this.labelArm.Location = new System.Drawing.Point(33, 236);
            this.labelArm.Name = "labelArm";
            this.labelArm.Size = new System.Drawing.Size(55, 13);
            this.labelArm.TabIndex = 6;
            this.labelArm.Text = "Armadura:";
            // 
            // labelNivel
            // 
            this.labelNivel.AutoSize = true;
            this.labelNivel.Location = new System.Drawing.Point(33, 189);
            this.labelNivel.Name = "labelNivel";
            this.labelNivel.Size = new System.Drawing.Size(34, 13);
            this.labelNivel.TabIndex = 5;
            this.labelNivel.Text = "Nivel:";
            // 
            // labelFuerza
            // 
            this.labelFuerza.AutoSize = true;
            this.labelFuerza.Location = new System.Drawing.Point(33, 141);
            this.labelFuerza.Name = "labelFuerza";
            this.labelFuerza.Size = new System.Drawing.Size(42, 13);
            this.labelFuerza.TabIndex = 4;
            this.labelFuerza.Text = "Fuerza:";
            // 
            // labelDes
            // 
            this.labelDes.AutoSize = true;
            this.labelDes.Location = new System.Drawing.Point(33, 90);
            this.labelDes.Name = "labelDes";
            this.labelDes.Size = new System.Drawing.Size(52, 13);
            this.labelDes.TabIndex = 3;
            this.labelDes.Text = "Destreza:";
            // 
            // labelVel
            // 
            this.labelVel.AutoSize = true;
            this.labelVel.Location = new System.Drawing.Point(33, 33);
            this.labelVel.Name = "labelVel";
            this.labelVel.Size = new System.Drawing.Size(57, 13);
            this.labelVel.TabIndex = 2;
            this.labelVel.Text = "Velocidad:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelSalud);
            this.groupBox1.Controls.Add(this.labelEdad);
            this.groupBox1.Controls.Add(this.labelFechNac);
            this.groupBox1.Controls.Add(this.labelTipo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(6, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 310);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // labelSalud
            // 
            this.labelSalud.AutoSize = true;
            this.labelSalud.Location = new System.Drawing.Point(26, 259);
            this.labelSalud.Name = "labelSalud";
            this.labelSalud.Size = new System.Drawing.Size(37, 13);
            this.labelSalud.TabIndex = 5;
            this.labelSalud.Text = "Salud:";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(26, 236);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(35, 13);
            this.labelEdad.TabIndex = 4;
            this.labelEdad.Text = "Edad:";
            // 
            // labelFechNac
            // 
            this.labelFechNac.AutoSize = true;
            this.labelFechNac.Location = new System.Drawing.Point(26, 175);
            this.labelFechNac.Name = "labelFechNac";
            this.labelFechNac.Size = new System.Drawing.Size(96, 13);
            this.labelFechNac.TabIndex = 3;
            this.labelFechNac.Text = "Fecha Nacimiento:";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(26, 33);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(31, 13);
            this.labelTipo.TabIndex = 2;
            this.labelTipo.Text = "Tipo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Apodo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nombre:";
            // 
            // comboBoxPersonajes
            // 
            this.comboBoxPersonajes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPersonajes.FormattingEnabled = true;
            this.comboBoxPersonajes.Location = new System.Drawing.Point(256, 19);
            this.comboBoxPersonajes.Name = "comboBoxPersonajes";
            this.comboBoxPersonajes.Size = new System.Drawing.Size(206, 21);
            this.comboBoxPersonajes.TabIndex = 7;
            this.comboBoxPersonajes.SelectedIndexChanged += new System.EventHandler(this.comboBoxPersonajes_SelectedIndexChanged);
            // 
            // btnIrBatalla
            // 
            this.btnIrBatalla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIrBatalla.Location = new System.Drawing.Point(730, 461);
            this.btnIrBatalla.Name = "btnIrBatalla";
            this.btnIrBatalla.Size = new System.Drawing.Size(113, 39);
            this.btnIrBatalla.TabIndex = 8;
            this.btnIrBatalla.Text = "Ir a Pelear!";
            this.btnIrBatalla.UseVisualStyleBackColor = true;
            this.btnIrBatalla.Click += new System.EventHandler(this.btnIrBatalla_Click);
            // 
            // btnGuardarListaPersj
            // 
            this.btnGuardarListaPersj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarListaPersj.Location = new System.Drawing.Point(730, 403);
            this.btnGuardarListaPersj.Name = "btnGuardarListaPersj";
            this.btnGuardarListaPersj.Size = new System.Drawing.Size(113, 39);
            this.btnGuardarListaPersj.TabIndex = 9;
            this.btnGuardarListaPersj.Text = "Guardar Lista Personajes";
            this.btnGuardarListaPersj.UseVisualStyleBackColor = true;
            this.btnGuardarListaPersj.Click += new System.EventHandler(this.btnGuardarListaPersj_Click);
            // 
            // FormCrearPersonaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 512);
            this.Controls.Add(this.btnIrBatalla);
            this.Controls.Add(this.groupDatos);
            this.Controls.Add(this.btnCrearEnemgos);
            this.Controls.Add(this.btnGuardarListaPersj);
            this.Controls.Add(this.groupPersonaje);
            this.MaximizeBox = false;
            this.Name = "FormCrearPersonaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personaje";
            this.groupPersonaje.ResumeLayout(false);
            this.groupPersonaje.PerformLayout();
            this.groupDatos.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnPersAleatorio;
        private System.Windows.Forms.Button btnCrearNuevoPerd;
        private System.Windows.Forms.Button btnCrearEnemgos;
        private System.Windows.Forms.GroupBox groupDatos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelArm;
        private System.Windows.Forms.Label labelNivel;
        private System.Windows.Forms.Label labelFuerza;
        private System.Windows.Forms.Label labelDes;
        private System.Windows.Forms.Label labelVel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSalud;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelFechNac;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxPersonajes;
        private System.Windows.Forms.Button btnIrBatalla;
        private System.Windows.Forms.Button btnGuardarListaPersj;
    }
}

