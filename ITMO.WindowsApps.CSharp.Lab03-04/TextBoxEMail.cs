using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace ITMO.WindowsApps.CSharp.Lab03_04
{
    public partial class TextBoxEMail : UserControl
    {
        public TextBoxEMail()
        {
            InitializeComponent();
        }

        private void textEmail_Validating(object sender, CancelEventArgs e)
        {
            if ((sender as TextBox).Text == "")
            {
                e.Cancel = false;
            }
            else
            {
                try
                {
                    var email = new MailAddress((sender as TextBox).Text);
                    e.Cancel = false;
                }
                catch
                {
                    e.Cancel = true;
                    MessageBox.Show("Неверный формат");
                }
            }
        }
    }
}
