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
    public partial class TextBoxChar : UserControl
    {
        public TextBoxChar()
        {
            InitializeComponent();
        }

        private void textChar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else if (char.IsDigit(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Данное поле может содержать только буквы");
            }
             
        }
    }
}
