namespace ITMO.WindowsApps.CSharp.Lab03_04
{
    partial class TextBoxEMail
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
            this.textEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textEmail
            // 
            this.textEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEmail.Location = new System.Drawing.Point(0, 0);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(103, 20);
            this.textEmail.TabIndex = 0;
            this.textEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textEmail_Validating);
            // 
            // TextBoxEMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textEmail);
            this.Name = "TextBoxEMail";
            this.Size = new System.Drawing.Size(103, 22);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textEmail;
    }
}
