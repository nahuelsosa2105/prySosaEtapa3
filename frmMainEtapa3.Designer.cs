namespace prySosaEtapa3
{
    partial class frmMainEtapa3
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
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnAvion = new System.Windows.Forms.Button();
            this.btnBarco = new System.Windows.Forms.Button();
            this.lblAuto = new System.Windows.Forms.Label();
            this.lblAvion = new System.Windows.Forms.Label();
            this.lblBarco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAuto
            // 
            this.btnAuto.BackColor = System.Drawing.Color.White;
            this.btnAuto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuto.Location = new System.Drawing.Point(27, 559);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(235, 43);
            this.btnAuto.TabIndex = 0;
            this.btnAuto.Text = "AUTO";
            this.btnAuto.UseVisualStyleBackColor = false;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnAvion
            // 
            this.btnAvion.BackColor = System.Drawing.Color.White;
            this.btnAvion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAvion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvion.Location = new System.Drawing.Point(304, 559);
            this.btnAvion.Name = "btnAvion";
            this.btnAvion.Size = new System.Drawing.Size(235, 43);
            this.btnAvion.TabIndex = 1;
            this.btnAvion.Text = "AVIÓN";
            this.btnAvion.UseVisualStyleBackColor = false;
            this.btnAvion.Click += new System.EventHandler(this.btnAvion_Click);
            // 
            // btnBarco
            // 
            this.btnBarco.BackColor = System.Drawing.Color.White;
            this.btnBarco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBarco.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarco.Location = new System.Drawing.Point(561, 559);
            this.btnBarco.Name = "btnBarco";
            this.btnBarco.Size = new System.Drawing.Size(235, 43);
            this.btnBarco.TabIndex = 2;
            this.btnBarco.Text = "BARCO";
            this.btnBarco.UseVisualStyleBackColor = false;
            this.btnBarco.Click += new System.EventHandler(this.btnBarco_Click);
            // 
            // lblAuto
            // 
            this.lblAuto.AutoSize = true;
            this.lblAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuto.Location = new System.Drawing.Point(93, 22);
            this.lblAuto.Name = "lblAuto";
            this.lblAuto.Size = new System.Drawing.Size(0, 31);
            this.lblAuto.TabIndex = 3;
            // 
            // lblAvion
            // 
            this.lblAvion.AutoSize = true;
            this.lblAvion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvion.Location = new System.Drawing.Point(365, 22);
            this.lblAvion.Name = "lblAvion";
            this.lblAvion.Size = new System.Drawing.Size(0, 31);
            this.lblAvion.TabIndex = 4;
            // 
            // lblBarco
            // 
            this.lblBarco.AutoSize = true;
            this.lblBarco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarco.Location = new System.Drawing.Point(662, 22);
            this.lblBarco.Name = "lblBarco";
            this.lblBarco.Size = new System.Drawing.Size(0, 31);
            this.lblBarco.TabIndex = 5;
            // 
            // frmMainEtapa3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prySosaEtapa3.Properties.Resources.FondoEtapa_3;
            this.ClientSize = new System.Drawing.Size(799, 614);
            this.Controls.Add(this.lblBarco);
            this.Controls.Add(this.lblAvion);
            this.Controls.Add(this.lblAuto);
            this.Controls.Add(this.btnBarco);
            this.Controls.Add(this.btnAvion);
            this.Controls.Add(this.btnAuto);
            this.Name = "frmMainEtapa3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CREAR OBJETOS POR CÓDIGO";
            this.Load += new System.EventHandler(this.frmMainEtapa3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnAvion;
        private System.Windows.Forms.Button btnBarco;
        private System.Windows.Forms.Label lblAuto;
        private System.Windows.Forms.Label lblAvion;
        private System.Windows.Forms.Label lblBarco;
    }
}

