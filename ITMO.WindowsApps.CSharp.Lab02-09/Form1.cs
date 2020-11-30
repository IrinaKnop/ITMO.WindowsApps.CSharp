using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ITMO.WindowsApps.CSharp.Lab02_06
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        List<Item> its = new List<Item>();

        public string Author // автор
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Title // Название
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string PublishHouse // Издательство
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public int Page // Количество страниц
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        public int Year // Год издания
        {
            get { return (int)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }
        public int InvNumber // Инвентарный номер
        {
            get { return (int)numericUpDown3.Value; }
            set { numericUpDown3.Value = value; }
        }
        public bool Existence // Наличие
        {
            get { return checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }
        public bool SortInvNumber // Сортировка по инвентарному номеру
        {
            get { return checkBox2.Checked; }
            set { checkBox2.Checked = value; }
        }
        public bool ReturnTime // Возвращение в срок
        {
            get { return checkBox3.Checked; }
            set { checkBox3.Checked = value; }
        }
        public int PeriodUse // Инвентарный номер
        {
            get { return (int)numericUpDown4.Value; }
            set { numericUpDown4.Value = value; }
        }
        public String Volume // том журнала
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }
        public int Number // номер журнала
        {
            get { return int.Parse(textBox5.Text); }
            set { textBox5.Text = value.ToString(); }
        }
        public String TitleM // название журнала
        { 
            get { return textBox6.Text; }
            set { textBox6.Text = value; }
        }
        public int YearM
        {
            get { return (int)numericUpDown5.Value; }
            set { numericUpDown5.Value = value; }
        }
        public int InvNumberM // Инвентарный номер
        {
            get { return (int)numericUpDown6.Value; }
            set { numericUpDown6.Value = value; }
        }
        public bool IfSubs
        {
            get { return checkBox4.Checked; }
            set { checkBox4.Checked = true; }
        }
        public bool Taken
        {
            get { return checkBox5.Checked; }
            set { checkBox5.Checked = value; }
        }


       private void button4_Click_1(object sender, EventArgs e)
        {
            Magazine m = new Magazine(Volume, Number, TitleM, YearM, InvNumberM, IfSubs);

            if (Taken)
                m.Return();

            if (IfSubs)
                m.Subs();

            its.Add(m);

            Volume = TitleM = "";
            Number = InvNumberM = 0;
            YearM = 1900;
            Taken = false;
            IfSubs = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Book b = new Book(Author, Title, PublishHouse, Page, Year, InvNumber, Existence);

            if (ReturnTime)
                b.ReturnSrok();

            b.PriceBook(PeriodUse);

            its.Add(b);

            Author = Title = PublishHouse = "";
            Page = InvNumber = PeriodUse = 0;
            Year = 1900;
            Existence = ReturnTime = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (SortInvNumber)
                its.Sort();
            StringBuilder sb = new StringBuilder();
            foreach (Item item in its)
            {
                sb.Append("\n" + item.ToString());
            }
            richTextBox1.Text = sb.ToString();
        }
    }
}

