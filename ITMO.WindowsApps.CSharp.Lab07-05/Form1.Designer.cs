namespace ITMO.WindowsApps.CSharp.Lab07_05
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.MaxValue = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.BtnRun = new System.Windows.Forms.Button();
            this.ResultTxb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите число";
            // 
            // MaxValue
            // 
            this.MaxValue.Location = new System.Drawing.Point(99, 12);
            this.MaxValue.Name = "MaxValue";
            this.MaxValue.Size = new System.Drawing.Size(159, 20);
            this.MaxValue.TabIndex = 1;
            this.MaxValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaxValue_KeyPress);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoEllipsis = true;
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(12, 92);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(59, 13);
            this.ResultLabel.TabIndex = 2;
            this.ResultLabel.Text = "Результат";
            // 
            // BtnRun
            // 
            this.BtnRun.Location = new System.Drawing.Point(15, 52);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(75, 23);
            this.BtnRun.TabIndex = 3;
            this.BtnRun.Text = "Посчитать";
            this.BtnRun.UseVisualStyleBackColor = true;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // ResultTxb
            // 
            this.ResultTxb.Location = new System.Drawing.Point(15, 108);
            this.ResultTxb.Multiline = true;
            this.ResultTxb.Name = "ResultTxb";
            this.ResultTxb.ReadOnly = true;
            this.ResultTxb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultTxb.Size = new System.Drawing.Size(243, 43);
            this.ResultTxb.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 163);
            this.Controls.Add(this.ResultTxb);
            this.Controls.Add(this.BtnRun);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.MaxValue);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaxValue;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button BtnRun;
        private System.Windows.Forms.TextBox ResultTxb;
    }
}

