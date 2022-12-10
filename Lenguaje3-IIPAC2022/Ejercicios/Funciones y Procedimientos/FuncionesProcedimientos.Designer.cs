namespace Ejercicio1
{
    partial class FuncionesProcedimientos
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
            this.Valor1TextBox = new System.Windows.Forms.TextBox();
            this.Valor2TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EjecutarButton = new System.Windows.Forms.Button();
            this.RestarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Valor1TextBox
            // 
            this.Valor1TextBox.Location = new System.Drawing.Point(249, 60);
            this.Valor1TextBox.Name = "Valor1TextBox";
            this.Valor1TextBox.Size = new System.Drawing.Size(213, 20);
            this.Valor1TextBox.TabIndex = 0;
            // 
            // Valor2TextBox
            // 
            this.Valor2TextBox.Location = new System.Drawing.Point(249, 104);
            this.Valor2TextBox.Name = "Valor2TextBox";
            this.Valor2TextBox.Size = new System.Drawing.Size(213, 20);
            this.Valor2TextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor 2";
            // 
            // EjecutarButton
            // 
            this.EjecutarButton.Location = new System.Drawing.Point(249, 157);
            this.EjecutarButton.Name = "EjecutarButton";
            this.EjecutarButton.Size = new System.Drawing.Size(213, 23);
            this.EjecutarButton.TabIndex = 4;
            this.EjecutarButton.Text = "Ejecutar";
            this.EjecutarButton.UseVisualStyleBackColor = true;
            this.EjecutarButton.Click += new System.EventHandler(this.EjecutarButton_Click);
            // 
            // RestarButton
            // 
            this.RestarButton.Location = new System.Drawing.Point(249, 206);
            this.RestarButton.Name = "RestarButton";
            this.RestarButton.Size = new System.Drawing.Size(213, 23);
            this.RestarButton.TabIndex = 5;
            this.RestarButton.Text = "Restar";
            this.RestarButton.UseVisualStyleBackColor = true;
            this.RestarButton.Click += new System.EventHandler(this.RestarButton_Click);
            // 
            // FuncionesProcedimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 424);
            this.Controls.Add(this.RestarButton);
            this.Controls.Add(this.EjecutarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Valor2TextBox);
            this.Controls.Add(this.Valor1TextBox);
            this.Name = "FuncionesProcedimientos";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Valor1TextBox;
        private System.Windows.Forms.TextBox Valor2TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EjecutarButton;
        private System.Windows.Forms.Button RestarButton;
    }
}

