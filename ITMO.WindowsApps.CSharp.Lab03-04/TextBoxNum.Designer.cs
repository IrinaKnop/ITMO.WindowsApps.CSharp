namespace ITMO.WindowsApps.CSharp.Lab03_04
{
    partial class TextBoxNum
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textNum
            // 
            this.textNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textNum.Location = new System.Drawing.Point(0, 0);
            this.textNum.Name = "textNum";
            this.textNum.Size = new System.Drawing.Size(102, 20);
            this.textNum.TabIndex = 0;
            this.textNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNum_KeyPress);
            // 
            // TextBoxNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textNum);
            this.Name = "TextBoxNum";
            this.Size = new System.Drawing.Size(102, 22);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textNum;
    }
}
