namespace SimpleCalculator
{
    partial class QuadraticEq
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
            this.ResultButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FactorA = new System.Windows.Forms.TextBox();
            this.FactorB = new System.Windows.Forms.TextBox();
            this.FactorC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ResultOut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ResultButton
            // 
            this.ResultButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ResultButton.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultButton.Location = new System.Drawing.Point(60, 220);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(75, 23);
            this.ResultButton.TabIndex = 0;
            this.ResultButton.Text = "Решить";
            this.ResultButton.UseVisualStyleBackColor = false;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ExitButton.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(227, 220);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Закрыть";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите коэффициенты квадратного уравнения";
            // 
            // FactorA
            // 
            this.FactorA.Location = new System.Drawing.Point(10, 44);
            this.FactorA.Name = "FactorA";
            this.FactorA.Size = new System.Drawing.Size(70, 20);
            this.FactorA.TabIndex = 3;
            this.FactorA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FactorA_KeyPress);
            // 
            // FactorB
            // 
            this.FactorB.Location = new System.Drawing.Point(134, 44);
            this.FactorB.Name = "FactorB";
            this.FactorB.Size = new System.Drawing.Size(70, 20);
            this.FactorB.TabIndex = 4;
            this.FactorB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FactorB_KeyPress);
            // 
            // FactorC
            // 
            this.FactorC.Location = new System.Drawing.Point(240, 44);
            this.FactorC.Name = "FactorC";
            this.FactorC.Size = new System.Drawing.Size(70, 20);
            this.FactorC.TabIndex = 5;
            this.FactorC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FactorC_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(78, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "x^2 +";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(202, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "x +";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(312, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "= 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Результат";
            // 
            // ResultOut
            // 
            this.ResultOut.Font = new System.Drawing.Font("Courier New", 11F);
            this.ResultOut.Location = new System.Drawing.Point(9, 142);
            this.ResultOut.Multiline = true;
            this.ResultOut.Name = "ResultOut";
            this.ResultOut.ReadOnly = true;
            this.ResultOut.Size = new System.Drawing.Size(338, 60);
            this.ResultOut.TabIndex = 10;
            // 
            // QuadraticEq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(356, 291);
            this.Controls.Add(this.ResultOut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FactorB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FactorA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FactorC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ResultButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "QuadraticEq";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Решение квадратного уравнения";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FactorA;
        private System.Windows.Forms.TextBox FactorB;
        private System.Windows.Forms.TextBox FactorC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ResultOut;
    }
}