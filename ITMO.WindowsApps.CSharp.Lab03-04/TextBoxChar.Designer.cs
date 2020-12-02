namespace ITMO.WindowsApps.CSharp.Lab03_04
{
    partial class TextBoxChar
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
            this.textChar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textChar
            // 
            this.textChar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textChar.Location = new System.Drawing.Point(0, 0);
            this.textChar.Name = "textChar";
            this.textChar.Size = new System.Drawing.Size(101, 20);
            this.textChar.TabIndex = 0;
            this.textChar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textChar_KeyPress);
            // 
            // TextBoxChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textChar);
            this.Name = "TextBoxChar";
            this.Size = new System.Drawing.Size(101, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textChar;
    }
}
