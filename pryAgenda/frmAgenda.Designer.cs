namespace pryAgenda
{
    partial class frmAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgenda));
            this.lblAgendaDeActividades = new System.Windows.Forms.Label();
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAgendaDeActividades
            // 
            this.lblAgendaDeActividades.AutoSize = true;
            this.lblAgendaDeActividades.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgendaDeActividades.Location = new System.Drawing.Point(210, 21);
            this.lblAgendaDeActividades.Name = "lblAgendaDeActividades";
            this.lblAgendaDeActividades.Size = new System.Drawing.Size(194, 18);
            this.lblAgendaDeActividades.TabIndex = 1;
            this.lblAgendaDeActividades.Text = "Agenda de Actividades";
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Location = new System.Drawing.Point(89, 54);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.Size = new System.Drawing.Size(454, 222);
            this.dgvAgenda.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(89, 296);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(136, 33);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(248, 296);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(136, 33);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(407, 296);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(136, 33);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(637, 359);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvAgenda);
            this.Controls.Add(this.lblAgendaDeActividades);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.frmAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgendaDeActividades;
        private System.Windows.Forms.DataGridView dgvAgenda;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
    }
}