namespace pryAgenda
{
    partial class frmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.lblActividad = new System.Windows.Forms.Label();
            this.txtActividad = new System.Windows.Forms.TextBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAbrirAgenda = new System.Windows.Forms.Button();
            this.lblCargarActividad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(93, 57);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(56, 18);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(155, 55);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacion.Location = new System.Drawing.Point(40, 159);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(109, 18);
            this.lblObservacion.TabIndex = 2;
            this.lblObservacion.Text = "Observación";
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividad.Location = new System.Drawing.Point(66, 108);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(83, 18);
            this.lblActividad.TabIndex = 3;
            this.lblActividad.Text = "Actividad";
            // 
            // txtActividad
            // 
            this.txtActividad.Location = new System.Drawing.Point(155, 106);
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.Size = new System.Drawing.Size(200, 20);
            this.txtActividad.TabIndex = 4;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(155, 160);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(200, 20);
            this.txtObservacion.TabIndex = 5;
            this.txtObservacion.TextChanged += new System.EventHandler(this.txtObservacion_TextChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(43, 209);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(98, 33);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(171, 209);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(98, 33);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAbrirAgenda
            // 
            this.btnAbrirAgenda.BackColor = System.Drawing.Color.Moccasin;
            this.btnAbrirAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbrirAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirAgenda.Location = new System.Drawing.Point(298, 209);
            this.btnAbrirAgenda.Name = "btnAbrirAgenda";
            this.btnAbrirAgenda.Size = new System.Drawing.Size(98, 33);
            this.btnAbrirAgenda.TabIndex = 8;
            this.btnAbrirAgenda.Text = "Abrir Agenda";
            this.btnAbrirAgenda.UseVisualStyleBackColor = false;
            this.btnAbrirAgenda.Click += new System.EventHandler(this.btnAbrirAgenda_Click);
            // 
            // lblCargarActividad
            // 
            this.lblCargarActividad.AutoSize = true;
            this.lblCargarActividad.Font = new System.Drawing.Font("Sitka Subheading", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargarActividad.Location = new System.Drawing.Point(148, 9);
            this.lblCargarActividad.Name = "lblCargarActividad";
            this.lblCargarActividad.Size = new System.Drawing.Size(133, 23);
            this.lblCargarActividad.TabIndex = 9;
            this.lblCargarActividad.Text = "Cargar Actividad";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(436, 263);
            this.Controls.Add(this.lblCargarActividad);
            this.Controls.Add(this.btnAbrirAgenda);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.txtActividad);
            this.Controls.Add(this.lblActividad);
            this.Controls.Add(this.lblObservacion);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actividad";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.TextBox txtActividad;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAbrirAgenda;
        private System.Windows.Forms.Label lblCargarActividad;
    }
}