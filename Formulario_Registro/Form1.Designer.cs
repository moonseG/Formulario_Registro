namespace Formulario_Registro
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
            this.laNombre = new System.Windows.Forms.Label();
            this.laApellido = new System.Windows.Forms.Label();
            this.laTelefono = new System.Windows.Forms.Label();
            this.laEstatura = new System.Windows.Forms.Label();
            this.laEdad = new System.Windows.Forms.Label();
            this.texNombre = new System.Windows.Forms.TextBox();
            this.texApellido = new System.Windows.Forms.TextBox();
            this.texTelefono = new System.Windows.Forms.TextBox();
            this.texEstatura = new System.Windows.Forms.TextBox();
            this.texEdad = new System.Windows.Forms.TextBox();
            this.BHombre = new System.Windows.Forms.RadioButton();
            this.BMujer = new System.Windows.Forms.RadioButton();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // laNombre
            // 
            this.laNombre.AutoSize = true;
            this.laNombre.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laNombre.Location = new System.Drawing.Point(68, 40);
            this.laNombre.Name = "laNombre";
            this.laNombre.Size = new System.Drawing.Size(82, 22);
            this.laNombre.TabIndex = 0;
            this.laNombre.Text = "Nombre";
            this.laNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // laApellido
            // 
            this.laApellido.AutoSize = true;
            this.laApellido.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laApellido.Location = new System.Drawing.Point(68, 81);
            this.laApellido.Name = "laApellido";
            this.laApellido.Size = new System.Drawing.Size(81, 22);
            this.laApellido.TabIndex = 1;
            this.laApellido.Text = "Apellido";
            // 
            // laTelefono
            // 
            this.laTelefono.AutoSize = true;
            this.laTelefono.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTelefono.Location = new System.Drawing.Point(68, 119);
            this.laTelefono.Name = "laTelefono";
            this.laTelefono.Size = new System.Drawing.Size(89, 22);
            this.laTelefono.TabIndex = 2;
            this.laTelefono.Text = "Telefono";
            // 
            // laEstatura
            // 
            this.laEstatura.AutoSize = true;
            this.laEstatura.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laEstatura.Location = new System.Drawing.Point(68, 158);
            this.laEstatura.Name = "laEstatura";
            this.laEstatura.Size = new System.Drawing.Size(86, 22);
            this.laEstatura.TabIndex = 3;
            this.laEstatura.Text = "Estatura";
            // 
            // laEdad
            // 
            this.laEdad.AutoSize = true;
            this.laEdad.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laEdad.Location = new System.Drawing.Point(68, 198);
            this.laEdad.Name = "laEdad";
            this.laEdad.Size = new System.Drawing.Size(54, 22);
            this.laEdad.TabIndex = 4;
            this.laEdad.Text = "Edad";
            // 
            // texNombre
            // 
            this.texNombre.BackColor = System.Drawing.Color.White;
            this.texNombre.Location = new System.Drawing.Point(236, 40);
            this.texNombre.Name = "texNombre";
            this.texNombre.Size = new System.Drawing.Size(100, 22);
            this.texNombre.TabIndex = 5;
            // 
            // texApellido
            // 
            this.texApellido.Location = new System.Drawing.Point(236, 81);
            this.texApellido.Name = "texApellido";
            this.texApellido.Size = new System.Drawing.Size(100, 22);
            this.texApellido.TabIndex = 6;
            // 
            // texTelefono
            // 
            this.texTelefono.Location = new System.Drawing.Point(236, 121);
            this.texTelefono.Name = "texTelefono";
            this.texTelefono.Size = new System.Drawing.Size(100, 22);
            this.texTelefono.TabIndex = 7;
            // 
            // texEstatura
            // 
            this.texEstatura.Location = new System.Drawing.Point(236, 158);
            this.texEstatura.Name = "texEstatura";
            this.texEstatura.Size = new System.Drawing.Size(100, 22);
            this.texEstatura.TabIndex = 8;
            // 
            // texEdad
            // 
            this.texEdad.Location = new System.Drawing.Point(236, 198);
            this.texEdad.Name = "texEdad";
            this.texEdad.Size = new System.Drawing.Size(100, 22);
            this.texEdad.TabIndex = 9;
            // 
            // BHombre
            // 
            this.BHombre.AutoSize = true;
            this.BHombre.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BHombre.Location = new System.Drawing.Point(71, 287);
            this.BHombre.Name = "BHombre";
            this.BHombre.Size = new System.Drawing.Size(87, 22);
            this.BHombre.TabIndex = 10;
            this.BHombre.TabStop = true;
            this.BHombre.Text = "Hombre";
            this.BHombre.UseVisualStyleBackColor = true;
            // 
            // BMujer
            // 
            this.BMujer.AutoSize = true;
            this.BMujer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMujer.Location = new System.Drawing.Point(202, 287);
            this.BMujer.Name = "BMujer";
            this.BMujer.Size = new System.Drawing.Size(72, 22);
            this.BMujer.TabIndex = 11;
            this.BMujer.TabStop = true;
            this.BMujer.Text = "Mujer";
            this.BMujer.UseVisualStyleBackColor = true;
            // 
            // BGuardar
            // 
            this.BGuardar.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardar.ForeColor = System.Drawing.Color.Blue;
            this.BGuardar.Location = new System.Drawing.Point(56, 349);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(123, 36);
            this.BGuardar.TabIndex = 12;
            this.BGuardar.Text = "GUARDAR";
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.AutoEllipsis = true;
            this.BCancelar.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BCancelar.Location = new System.Drawing.Point(185, 349);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(151, 36);
            this.BCancelar.TabIndex = 13;
            this.BCancelar.Text = "CANCELAR";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Genero";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(410, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.BMujer);
            this.Controls.Add(this.BHombre);
            this.Controls.Add(this.texEdad);
            this.Controls.Add(this.texEstatura);
            this.Controls.Add(this.texTelefono);
            this.Controls.Add(this.texApellido);
            this.Controls.Add(this.texNombre);
            this.Controls.Add(this.laEdad);
            this.Controls.Add(this.laEstatura);
            this.Controls.Add(this.laTelefono);
            this.Controls.Add(this.laApellido);
            this.Controls.Add(this.laNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laNombre;
        private System.Windows.Forms.Label laApellido;
        private System.Windows.Forms.Label laTelefono;
        private System.Windows.Forms.Label laEstatura;
        private System.Windows.Forms.Label laEdad;
        private System.Windows.Forms.TextBox texNombre;
        private System.Windows.Forms.TextBox texApellido;
        private System.Windows.Forms.TextBox texTelefono;
        private System.Windows.Forms.TextBox texEstatura;
        private System.Windows.Forms.TextBox texEdad;
        private System.Windows.Forms.RadioButton BHombre;
        private System.Windows.Forms.RadioButton BMujer;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Label label1;
    }
}

