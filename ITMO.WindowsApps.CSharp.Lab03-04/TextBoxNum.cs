using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WindowsApps.CSharp.Lab03_04
{
    public partial class TextBoxNum : UserControl
    {
        public TextBoxNum()
        {
            InitializeComponent();
        }

        private void textNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Данное поле может содержать только цифры");
            }
            else if (e.KeyChar == ' ')
            {
                e.Handled = true;
                MessageBox.Show("Данное поле может содержать только цифры");
            }
        }
    }
}
