using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WindowsApps.CSharp.Lab03_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Users> users = new List<Users>();

        public string UserSurname // Фамилия
        {
            get { return textBoxSurname.textChar.Text; }
            set { textBoxSurname.textChar.Text = value; }
        }
        public string UserName // Имя
        {
            get { return textBoxName.textChar.Text; }
            set { textBoxName.textChar.Text = value; }
        }
        public string UserPatronymic //Отчество
        {
            get { return textBoxPatronymic.textChar.Text; }
            set { textBoxPatronymic.textChar.Text = value; }
        }
        public string UserAge // Возраст
        {
            get { return textBoxAge.textNum.Text; }
            set { textBoxAge.textNum.Text = value; }
        }
        public string UserPhoneIndex // Индекс номера телефона
        {
            get { return phoneNumberIndex.textNum.Text; }
            set { phoneNumberIndex.textNum.Text = value; }
        }
        public string UserPhone // Номер телефона
        {
            get { return phoneNumber.textNum.Text; }
            set { phoneNumber.textNum.Text = value; }
        }
        public string UserEmail //e-mail
        {
            get { return textBoxEmail.textEmail.Text; }
            set { textBoxEmail.textEmail.Text = value; }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Users newUser = new Users(UserSurname, UserName, UserPatronymic, UserAge, UserPhoneIndex, UserPhone, UserEmail);
            users.Add(newUser);

            UserSurname = UserName = UserPatronymic = UserAge = UserPhoneIndex = UserPhone = UserEmail = "";
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Users user in users)
            {
                sb.Append("\n" + user.ToString());
            }
            richTextBox1.Text = sb.ToString();
        }
    }
}
