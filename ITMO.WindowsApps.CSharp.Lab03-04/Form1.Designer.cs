namespace ITMO.WindowsApps.CSharp.Lab03_04
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.patronymic = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.textBoxEmail = new ITMO.WindowsApps.CSharp.Lab03_04.TextBoxEMail();
            this.phoneNumber = new ITMO.WindowsApps.CSharp.Lab03_04.TextBoxNum();
            this.textBoxAge = new ITMO.WindowsApps.CSharp.Lab03_04.TextBoxNum();
            this.phoneNumberIndex = new ITMO.WindowsApps.CSharp.Lab03_04.TextBoxNum();
            this.textBoxPatronymic = new ITMO.WindowsApps.CSharp.Lab03_04.TextBoxChar();
            this.textBoxName = new ITMO.WindowsApps.CSharp.Lab03_04.TextBoxChar();
            this.textBoxSurname = new ITMO.WindowsApps.CSharp.Lab03_04.TextBoxChar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.phoneNumber);
            this.groupBox1.Controls.Add(this.textBoxAge);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.phoneNumberIndex);
            this.groupBox1.Controls.Add(this.age);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.textBoxPatronymic);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.patronymic);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.textBoxSurname);
            this.groupBox1.Controls.Add(this.surname);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите данные пользователя";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = ")";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(6, 115);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(49, 13);
            this.age.TabIndex = 13;
            this.age.Text = "Возраст";
            
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "+7 (";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(8, 198);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(34, 13);
            this.email.TabIndex = 10;
            this.email.Text = "e-mail";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(6, 166);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(52, 13);
            this.phone.TabIndex = 9;
            this.phone.Text = "Телефон";
            // 
            // patronymic
            // 
            this.patronymic.AutoSize = true;
            this.patronymic.Location = new System.Drawing.Point(6, 88);
            this.patronymic.Name = "patronymic";
            this.patronymic.Size = new System.Drawing.Size(54, 13);
            this.patronymic.TabIndex = 6;
            this.patronymic.Text = "Отчество";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(6, 61);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(29, 13);
            this.name.TabIndex = 5;
            this.name.Text = "Имя";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Location = new System.Drawing.Point(6, 36);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(56, 13);
            this.surname.TabIndex = 3;
            this.surname.Text = "Фамилия";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(391, 17);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(397, 232);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(23, 270);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(122, 37);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(407, 270);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(108, 37);
            this.buttonShow.TabIndex = 3;
            this.buttonShow.Text = "Показать";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(80, 194);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(163, 22);
            this.textBoxEmail.TabIndex = 18;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(141, 162);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(102, 22);
            this.phoneNumber.TabIndex = 17;
            this.phoneNumber.textNum.MaxLength = 7;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(80, 115);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(62, 22);
            this.textBoxAge.TabIndex = 16;
            this.textBoxAge.textNum.MaxLength = 2;
            // 
            // phoneNumberIndex
            // 
            this.phoneNumberIndex.Location = new System.Drawing.Point(106, 162);
            this.phoneNumberIndex.Name = "phoneNumberIndex";
            this.phoneNumberIndex.Size = new System.Drawing.Size(25, 22);
            this.phoneNumberIndex.TabIndex = 14;
            this.phoneNumberIndex.textNum.MaxLength = 3;
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(80, 88);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(287, 21);
            this.textBoxPatronymic.TabIndex = 8;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(80, 61);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(287, 21);
            this.textBoxName.TabIndex = 7;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.AutoSize = true;
            this.textBoxSurname.Location = new System.Drawing.Point(80, 36);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(287, 23);
            this.textBoxSurname.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 331);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Данные о пользователях";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private TextBoxChar textBoxSurname;
        private System.Windows.Forms.Label surname;
        private TextBoxChar textBoxPatronymic;
        private TextBoxChar textBoxName;
        private System.Windows.Forms.Label patronymic;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label age;
        private TextBoxNum phoneNumberIndex;
        private TextBoxNum textBoxAge;
        private System.Windows.Forms.Label label8;
        private TextBoxNum phoneNumber;
        private TextBoxEMail textBoxEmail;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonShow;
    }
}

