namespace KevinZuniga
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
            this.CalculoInteresListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CalcularInteresButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CalculoInteresListBox
            // 
            this.CalculoInteresListBox.FormattingEnabled = true;
            this.CalculoInteresListBox.Location = new System.Drawing.Point(12, 175);
            this.CalculoInteresListBox.Name = "CalculoInteresListBox";
            this.CalculoInteresListBox.Size = new System.Drawing.Size(516, 199);
            this.CalculoInteresListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CALCULO DE INTERES MENSUAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KevinZuniga.Properties.Resources.interesar__1_;
            this.pictureBox1.Location = new System.Drawing.Point(340, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // CalcularInteresButton
            // 
            this.CalcularInteresButton.Location = new System.Drawing.Point(12, 128);
            this.CalcularInteresButton.Name = "CalcularInteresButton";
            this.CalcularInteresButton.Size = new System.Drawing.Size(190, 23);
            this.CalcularInteresButton.TabIndex = 3;
            this.CalcularInteresButton.Text = "CALCULAR INTERES AHORA";
            this.CalcularInteresButton.UseVisualStyleBackColor = true;
            this.CalcularInteresButton.Click += new System.EventHandler(this.CalcularInteresButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 384);
            this.Controls.Add(this.CalcularInteresButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalculoInteresListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CalculoInteresListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CalcularInteresButton;
    }
}

