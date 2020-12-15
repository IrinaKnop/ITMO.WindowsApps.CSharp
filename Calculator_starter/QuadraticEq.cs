using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Equation;

namespace SimpleCalculator
{
    public partial class QuadraticEq : Form
    {
        
        private double NumA
        {
            get { return double.Parse(FactorA.Text); }
            set { FactorA.Text = value.ToString(); }
        }
        private double NumB
        {
            get { return double.Parse(FactorB.Text); }
            set { FactorB.Text = value.ToString(); }
        }
        private double NumC
        {
            get { return double.Parse(FactorC.Text); }
            set { FactorC.Text = value.ToString(); }
        }

        public QuadraticEq()
        {
            InitializeComponent();
        }
        private void ResultButton_Click(object sender, EventArgs e)
        {
            int i = Ur2.CalcRoots(NumA, NumB, NumC, out double x1, out double x2);

            if (i > 0)
            {
                ResultOut.Text = "Корни уравнения с коэффициентами a = " + NumA + ", b = " + NumB + ", c = " + NumC + " равны: x1 = " + x1 + ", x2 = " + x2 + ".";
            }
            else if (i == 0)
            {
                ResultOut.Text = "Корень уравнения с коэффициентами a = " + NumA + ", b = " + NumB + ", c = " + NumC + " один: x1 = x2 = " + x1 + ".";
            }
            else
            {
                ResultOut.Text = "Действительных корней уравнения с коэффициентами a = " + NumA + ", b = " + NumB + ", c = " + NumC + " нет.";
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FactorA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '-') || (e.KeyChar == '.'))
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Можно вводить только цифры");
            }
        }

        private void FactorB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '-') || (e.KeyChar == '.'))
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Можно вводить только цифры");
            }
        }

        private void FactorC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '-') || (e.KeyChar == '.'))
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Можно вводить только цифры");
            }
        }

        
    }
}
