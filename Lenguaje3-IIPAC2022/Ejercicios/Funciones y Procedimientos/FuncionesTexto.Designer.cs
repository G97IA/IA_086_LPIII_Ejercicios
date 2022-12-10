namespace Ejercicio1
{
    partial class FuncionesTexto
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
            this.CadenaTextBox = new System.Windows.Forms.TextBox();
            this.GenerarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LongitudLabel = new System.Windows.Forms.Label();
            this.PrimerCaracterLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UltimoCaracterLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MayusculasLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MinusculasLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ReemplazarLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CadenaTextBox
            // 
            this.CadenaTextBox.Location = new System.Drawing.Point(225, 15);
            this.CadenaTextBox.Name = "CadenaTextBox";
            this.CadenaTextBox.PasswordChar = '*';
            this.CadenaTextBox.Size = new System.Drawing.Size(244, 20);
            this.CadenaTextBox.TabIndex = 0;
            this.CadenaTextBox.TextChanged += new System.EventHandler(this.CadenaTextBox_TextChanged);
            // 
            // GenerarButton
            // 
            this.GenerarButton.Location = new System.Drawing.Point(525, 12);
            this.GenerarButton.Name = "GenerarButton";
            this.GenerarButton.Size = new System.Drawing.Size(75, 23);
            this.GenerarButton.TabIndex = 1;
            this.GenerarButton.Text = "Generar";
            this.GenerarButton.UseVisualStyleBackColor = true;
            this.GenerarButton.Click += new System.EventHandler(this.GenerarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Longitud:";
            // 
            // LongitudLabel
            // 
            this.LongitudLabel.AutoSize = true;
            this.LongitudLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LongitudLabel.Location = new System.Drawing.Point(238, 98);
            this.LongitudLabel.Name = "LongitudLabel";
            this.LongitudLabel.Size = new System.Drawing.Size(41, 13);
            this.LongitudLabel.TabIndex = 3;
            this.LongitudLabel.Text = "label2";
            // 
            // PrimerCaracterLabel
            // 
            this.PrimerCaracterLabel.AutoSize = true;
            this.PrimerCaracterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrimerCaracterLabel.Location = new System.Drawing.Point(238, 130);
            this.PrimerCaracterLabel.Name = "PrimerCaracterLabel";
            this.PrimerCaracterLabel.Size = new System.Drawing.Size(41, 13);
            this.PrimerCaracterLabel.TabIndex = 5;
            this.PrimerCaracterLabel.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Primer Caracter:";
            // 
            // UltimoCaracterLabel
            // 
            this.UltimoCaracterLabel.AutoSize = true;
            this.UltimoCaracterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UltimoCaracterLabel.Location = new System.Drawing.Point(238, 162);
            this.UltimoCaracterLabel.Name = "UltimoCaracterLabel";
            this.UltimoCaracterLabel.Size = new System.Drawing.Size(41, 13);
            this.UltimoCaracterLabel.TabIndex = 7;
            this.UltimoCaracterLabel.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Último Caracter:";
            // 
            // MayusculasLabel
            // 
            this.MayusculasLabel.AutoSize = true;
            this.MayusculasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MayusculasLabel.Location = new System.Drawing.Point(238, 198);
            this.MayusculasLabel.Name = "MayusculasLabel";
            this.MayusculasLabel.Size = new System.Drawing.Size(41, 13);
            this.MayusculasLabel.TabIndex = 9;
            this.MayusculasLabel.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mayúsculas:";
            // 
            // MinusculasLabel
            // 
            this.MinusculasLabel.AutoSize = true;
            this.MinusculasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusculasLabel.Location = new System.Drawing.Point(238, 228);
            this.MinusculasLabel.Name = "MinusculasLabel";
            this.MinusculasLabel.Size = new System.Drawing.Size(41, 13);
            this.MinusculasLabel.TabIndex = 11;
            this.MinusculasLabel.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Minúsculas:";
            // 
            // ReemplazarLabel
            // 
            this.ReemplazarLabel.AutoSize = true;
            this.ReemplazarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReemplazarLabel.Location = new System.Drawing.Point(238, 264);
            this.ReemplazarLabel.Name = "ReemplazarLabel";
            this.ReemplazarLabel.Size = new System.Drawing.Size(41, 13);
            this.ReemplazarLabel.TabIndex = 13;
            this.ReemplazarLabel.Text = "label2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Reemplazar:";
            // 
            // FuncionesTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 452);
            this.Controls.Add(this.ReemplazarLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MinusculasLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MayusculasLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UltimoCaracterLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PrimerCaracterLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LongitudLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenerarButton);
            this.Controls.Add(this.CadenaTextBox);
            this.Name = "FuncionesTexto";
            this.Text = "FuncionesTexto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CadenaTextBox;
        private System.Windows.Forms.Button GenerarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LongitudLabel;
        private System.Windows.Forms.Label PrimerCaracterLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label UltimoCaracterLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label MayusculasLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MinusculasLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ReemplazarLabel;
        private System.Windows.Forms.Label label7;
    }
}