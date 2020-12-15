using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Calculator;

namespace SimpleCalculator
{
	/// <summary>
	/// Summary description for CalcUI.
	/// </summary>
	public class CalcUI : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox VersionInfo;
		private System.Windows.Forms.Button KeyExit;
		private System.Windows.Forms.Button KeyDate;
		private System.Windows.Forms.TextBox OutputDisplay;
		private System.Windows.Forms.Button KeyClear;
		private System.Windows.Forms.Button KeyMinus;
		private System.Windows.Forms.Button KeyPlus;
		private System.Windows.Forms.Button KeyEqual;
		private System.Windows.Forms.Button KeyMultiply;
		private System.Windows.Forms.Button KeyDivide;
		private System.Windows.Forms.Button KeyPoint;
		private System.Windows.Forms.Button KeySign;
		private System.Windows.Forms.Button KeyZero;
		private System.Windows.Forms.Button KeyNine;
		private System.Windows.Forms.Button KeyEight;
		private System.Windows.Forms.Button KeySeven;
		private System.Windows.Forms.Button KeySix;
		private System.Windows.Forms.Button KeyFive;
		private System.Windows.Forms.Button KeyFour;
		private System.Windows.Forms.Button KeyThree;
		private System.Windows.Forms.Button KeyTwo;
		private System.Windows.Forms.Button KeyOne;

		// Output Display Constants.
		private const string oneOut = "1";
		private const string twoOut = "2";
		private const string threeOut = "3";
		private const string fourOut = "4";
		private const string fiveOut = "5";
		private const string sixOut = "6";
		private const string sevenOut = "7";
		private const string eightOut = "8";
		private const string nineOut = "9";
		private const string zeroOut = "0";

        private MenuStrip menuStrip1;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem simpleToolStripMenuItem;
        private ToolStripMenuItem engineeringToolStripMenuItem;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button KeyDegree;
        private Button KeySquaring;
        private Button KeySqrt;
        private Button KeyCubeRoot;
        private Button KeyReverse;
        private Button KeyFactorial;
        private Button KeyQuadraticEq;
        private ToolTip toolTip1;
        private IContainer components;

        public CalcUI()
		{
			//
			// Required for Windows Form Designer support
			//

			InitializeComponent();

			//
			// Get version information from the Calculator Module.
			//

			VersionInfo.Text = CalculatorEngine.GetVersion();
			OutputDisplay.Text = "0";
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.KeyDate = new System.Windows.Forms.Button();
            this.KeyOne = new System.Windows.Forms.Button();
            this.VersionInfo = new System.Windows.Forms.TextBox();
            this.KeySix = new System.Windows.Forms.Button();
            this.KeyFive = new System.Windows.Forms.Button();
            this.KeyEqual = new System.Windows.Forms.Button();
            this.KeyTwo = new System.Windows.Forms.Button();
            this.KeyZero = new System.Windows.Forms.Button();
            this.KeyThree = new System.Windows.Forms.Button();
            this.KeyPlus = new System.Windows.Forms.Button();
            this.KeyExit = new System.Windows.Forms.Button();
            this.KeySign = new System.Windows.Forms.Button();
            this.KeySeven = new System.Windows.Forms.Button();
            this.KeyPoint = new System.Windows.Forms.Button();
            this.KeyNine = new System.Windows.Forms.Button();
            this.OutputDisplay = new System.Windows.Forms.TextBox();
            this.KeyMinus = new System.Windows.Forms.Button();
            this.KeyEight = new System.Windows.Forms.Button();
            this.KeyMultiply = new System.Windows.Forms.Button();
            this.KeyFour = new System.Windows.Forms.Button();
            this.KeyClear = new System.Windows.Forms.Button();
            this.KeyDivide = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engineeringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KeyQuadraticEq = new System.Windows.Forms.Button();
            this.KeyFactorial = new System.Windows.Forms.Button();
            this.KeyReverse = new System.Windows.Forms.Button();
            this.KeyCubeRoot = new System.Windows.Forms.Button();
            this.KeySqrt = new System.Windows.Forms.Button();
            this.KeySquaring = new System.Windows.Forms.Button();
            this.KeyDegree = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeyDate
            // 
            this.KeyDate.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyDate.ForeColor = System.Drawing.Color.Blue;
            this.KeyDate.Location = new System.Drawing.Point(200, 144);
            this.KeyDate.Name = "KeyDate";
            this.KeyDate.Size = new System.Drawing.Size(56, 40);
            this.KeyDate.TabIndex = 19;
            this.KeyDate.TabStop = false;
            this.KeyDate.Text = "Date";
            this.toolTip1.SetToolTip(this.KeyDate, "Дата");
            this.KeyDate.Click += new System.EventHandler(this.KeyDate_Click);
            // 
            // KeyOne
            // 
            this.KeyOne.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyOne.ForeColor = System.Drawing.Color.Blue;
            this.KeyOne.Location = new System.Drawing.Point(8, 192);
            this.KeyOne.Name = "KeyOne";
            this.KeyOne.Size = new System.Drawing.Size(40, 40);
            this.KeyOne.TabIndex = 2;
            this.KeyOne.TabStop = false;
            this.KeyOne.Text = "1";
            this.KeyOne.Click += new System.EventHandler(this.KeyOne_Click);
            // 
            // VersionInfo
            // 
            this.VersionInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.VersionInfo.Cursor = System.Windows.Forms.Cursors.No;
            this.VersionInfo.Font = new System.Drawing.Font("Verdana", 8F);
            this.VersionInfo.Location = new System.Drawing.Point(8, 27);
            this.VersionInfo.Name = "VersionInfo";
            this.VersionInfo.ReadOnly = true;
            this.VersionInfo.Size = new System.Drawing.Size(248, 20);
            this.VersionInfo.TabIndex = 0;
            this.VersionInfo.TabStop = false;
            this.VersionInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KeySix
            // 
            this.KeySix.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySix.ForeColor = System.Drawing.Color.Blue;
            this.KeySix.Location = new System.Drawing.Point(104, 144);
            this.KeySix.Name = "KeySix";
            this.KeySix.Size = new System.Drawing.Size(40, 40);
            this.KeySix.TabIndex = 7;
            this.KeySix.TabStop = false;
            this.KeySix.Text = "6";
            this.KeySix.Click += new System.EventHandler(this.KeySix_Click);
            // 
            // KeyFive
            // 
            this.KeyFive.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFive.ForeColor = System.Drawing.Color.Blue;
            this.KeyFive.Location = new System.Drawing.Point(56, 144);
            this.KeyFive.Name = "KeyFive";
            this.KeyFive.Size = new System.Drawing.Size(40, 40);
            this.KeyFive.TabIndex = 6;
            this.KeyFive.TabStop = false;
            this.KeyFive.Text = "5";
            this.KeyFive.Click += new System.EventHandler(this.KeyFive_Click);
            // 
            // KeyEqual
            // 
            this.KeyEqual.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyEqual.ForeColor = System.Drawing.Color.Red;
            this.KeyEqual.Location = new System.Drawing.Point(200, 240);
            this.KeyEqual.Name = "KeyEqual";
            this.KeyEqual.Size = new System.Drawing.Size(56, 40);
            this.KeyEqual.TabIndex = 18;
            this.KeyEqual.TabStop = false;
            this.KeyEqual.Text = "=";
            this.toolTip1.SetToolTip(this.KeyEqual, "Равно");
            this.KeyEqual.Click += new System.EventHandler(this.KeyEqual_Click);
            // 
            // KeyTwo
            // 
            this.KeyTwo.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyTwo.ForeColor = System.Drawing.Color.Blue;
            this.KeyTwo.Location = new System.Drawing.Point(56, 192);
            this.KeyTwo.Name = "KeyTwo";
            this.KeyTwo.Size = new System.Drawing.Size(40, 40);
            this.KeyTwo.TabIndex = 3;
            this.KeyTwo.TabStop = false;
            this.KeyTwo.Text = "2";
            this.KeyTwo.Click += new System.EventHandler(this.KeyTwo_Click);
            // 
            // KeyZero
            // 
            this.KeyZero.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyZero.ForeColor = System.Drawing.Color.Blue;
            this.KeyZero.Location = new System.Drawing.Point(8, 240);
            this.KeyZero.Name = "KeyZero";
            this.KeyZero.Size = new System.Drawing.Size(40, 40);
            this.KeyZero.TabIndex = 11;
            this.KeyZero.TabStop = false;
            this.KeyZero.Text = "0";
            this.KeyZero.Click += new System.EventHandler(this.KeyZero_Click);
            // 
            // KeyThree
            // 
            this.KeyThree.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyThree.ForeColor = System.Drawing.Color.Blue;
            this.KeyThree.Location = new System.Drawing.Point(104, 192);
            this.KeyThree.Name = "KeyThree";
            this.KeyThree.Size = new System.Drawing.Size(40, 40);
            this.KeyThree.TabIndex = 4;
            this.KeyThree.TabStop = false;
            this.KeyThree.Text = "3";
            this.KeyThree.Click += new System.EventHandler(this.KeyThree_Click);
            // 
            // KeyPlus
            // 
            this.KeyPlus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPlus.ForeColor = System.Drawing.Color.Red;
            this.KeyPlus.Location = new System.Drawing.Point(152, 240);
            this.KeyPlus.Name = "KeyPlus";
            this.KeyPlus.Size = new System.Drawing.Size(40, 40);
            this.KeyPlus.TabIndex = 12;
            this.KeyPlus.TabStop = false;
            this.KeyPlus.Text = "+";
            this.toolTip1.SetToolTip(this.KeyPlus, "Плюс");
            this.KeyPlus.Click += new System.EventHandler(this.KeyPlus_Click);
            // 
            // KeyExit
            // 
            this.KeyExit.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyExit.ForeColor = System.Drawing.Color.Red;
            this.KeyExit.Location = new System.Drawing.Point(200, 192);
            this.KeyExit.Name = "KeyExit";
            this.KeyExit.Size = new System.Drawing.Size(56, 40);
            this.KeyExit.TabIndex = 21;
            this.KeyExit.TabStop = false;
            this.KeyExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.KeyExit, "Выход");
            this.KeyExit.Click += new System.EventHandler(this.KeyExit_Click);
            // 
            // KeySign
            // 
            this.KeySign.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.KeySign.ForeColor = System.Drawing.Color.Blue;
            this.KeySign.Location = new System.Drawing.Point(104, 240);
            this.KeySign.Name = "KeySign";
            this.KeySign.Size = new System.Drawing.Size(40, 40);
            this.KeySign.TabIndex = 16;
            this.KeySign.TabStop = false;
            this.KeySign.Text = "+/-";
            this.KeySign.Click += new System.EventHandler(this.KeySign_Click);
            // 
            // KeySeven
            // 
            this.KeySeven.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySeven.ForeColor = System.Drawing.Color.Blue;
            this.KeySeven.Location = new System.Drawing.Point(8, 96);
            this.KeySeven.Name = "KeySeven";
            this.KeySeven.Size = new System.Drawing.Size(40, 40);
            this.KeySeven.TabIndex = 8;
            this.KeySeven.TabStop = false;
            this.KeySeven.Text = "7";
            this.KeySeven.Click += new System.EventHandler(this.KeySeven_Click);
            // 
            // KeyPoint
            // 
            this.KeyPoint.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPoint.ForeColor = System.Drawing.Color.Blue;
            this.KeyPoint.Location = new System.Drawing.Point(56, 240);
            this.KeyPoint.Name = "KeyPoint";
            this.KeyPoint.Size = new System.Drawing.Size(40, 40);
            this.KeyPoint.TabIndex = 17;
            this.KeyPoint.TabStop = false;
            this.KeyPoint.Text = ".";
            this.KeyPoint.Click += new System.EventHandler(this.KeyPoint_Click);
            // 
            // KeyNine
            // 
            this.KeyNine.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyNine.ForeColor = System.Drawing.Color.Blue;
            this.KeyNine.Location = new System.Drawing.Point(104, 96);
            this.KeyNine.Name = "KeyNine";
            this.KeyNine.Size = new System.Drawing.Size(40, 40);
            this.KeyNine.TabIndex = 10;
            this.KeyNine.TabStop = false;
            this.KeyNine.Text = "9";
            this.KeyNine.Click += new System.EventHandler(this.KeyNine_Click);
            // 
            // OutputDisplay
            // 
            this.OutputDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OutputDisplay.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.OutputDisplay.Location = new System.Drawing.Point(8, 56);
            this.OutputDisplay.Name = "OutputDisplay";
            this.OutputDisplay.ReadOnly = true;
            this.OutputDisplay.Size = new System.Drawing.Size(248, 26);
            this.OutputDisplay.TabIndex = 1;
            this.OutputDisplay.TabStop = false;
            this.OutputDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // KeyMinus
            // 
            this.KeyMinus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyMinus.ForeColor = System.Drawing.Color.Red;
            this.KeyMinus.Location = new System.Drawing.Point(152, 192);
            this.KeyMinus.Name = "KeyMinus";
            this.KeyMinus.Size = new System.Drawing.Size(40, 40);
            this.KeyMinus.TabIndex = 13;
            this.KeyMinus.TabStop = false;
            this.KeyMinus.Text = "-";
            this.toolTip1.SetToolTip(this.KeyMinus, "Минус");
            this.KeyMinus.Click += new System.EventHandler(this.KeyMinus_Click);
            // 
            // KeyEight
            // 
            this.KeyEight.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyEight.ForeColor = System.Drawing.Color.Blue;
            this.KeyEight.Location = new System.Drawing.Point(56, 96);
            this.KeyEight.Name = "KeyEight";
            this.KeyEight.Size = new System.Drawing.Size(40, 40);
            this.KeyEight.TabIndex = 9;
            this.KeyEight.TabStop = false;
            this.KeyEight.Text = "8";
            this.KeyEight.Click += new System.EventHandler(this.KeyEight_Click);
            // 
            // KeyMultiply
            // 
            this.KeyMultiply.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyMultiply.ForeColor = System.Drawing.Color.Red;
            this.KeyMultiply.Location = new System.Drawing.Point(152, 144);
            this.KeyMultiply.Name = "KeyMultiply";
            this.KeyMultiply.Size = new System.Drawing.Size(40, 40);
            this.KeyMultiply.TabIndex = 14;
            this.KeyMultiply.TabStop = false;
            this.KeyMultiply.Text = "*";
            this.toolTip1.SetToolTip(this.KeyMultiply, "Умножить");
            this.KeyMultiply.Click += new System.EventHandler(this.KeyMultiply_Click);
            // 
            // KeyFour
            // 
            this.KeyFour.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFour.ForeColor = System.Drawing.Color.Blue;
            this.KeyFour.Location = new System.Drawing.Point(8, 144);
            this.KeyFour.Name = "KeyFour";
            this.KeyFour.Size = new System.Drawing.Size(40, 40);
            this.KeyFour.TabIndex = 5;
            this.KeyFour.TabStop = false;
            this.KeyFour.Text = "4";
            this.KeyFour.Click += new System.EventHandler(this.KeyFour_Click);
            // 
            // KeyClear
            // 
            this.KeyClear.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyClear.ForeColor = System.Drawing.Color.Red;
            this.KeyClear.Location = new System.Drawing.Point(200, 96);
            this.KeyClear.Name = "KeyClear";
            this.KeyClear.Size = new System.Drawing.Size(56, 40);
            this.KeyClear.TabIndex = 20;
            this.KeyClear.TabStop = false;
            this.KeyClear.Text = "C";
            this.toolTip1.SetToolTip(this.KeyClear, "Очистить");
            this.KeyClear.Click += new System.EventHandler(this.KeyClear_Click);
            // 
            // KeyDivide
            // 
            this.KeyDivide.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyDivide.ForeColor = System.Drawing.Color.Red;
            this.KeyDivide.Location = new System.Drawing.Point(152, 96);
            this.KeyDivide.Name = "KeyDivide";
            this.KeyDivide.Size = new System.Drawing.Size(40, 40);
            this.KeyDivide.TabIndex = 15;
            this.KeyDivide.TabStop = false;
            this.KeyDivide.Text = "/";
            this.toolTip1.SetToolTip(this.KeyDivide, "Разделить");
            this.KeyDivide.Click += new System.EventHandler(this.KeyDivide_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(264, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.menuToolStripMenuItem.Text = "&Меню";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.clearToolStripMenuItem.Text = "&Очистить";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.exitToolStripMenuItem.Text = "&Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleToolStripMenuItem,
            this.engineeringToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.viewToolStripMenuItem.Text = "&Вид";
            // 
            // simpleToolStripMenuItem
            // 
            this.simpleToolStripMenuItem.Name = "simpleToolStripMenuItem";
            this.simpleToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.simpleToolStripMenuItem.Text = "&Обычный";
            this.simpleToolStripMenuItem.Click += new System.EventHandler(this.simpleToolStripMenuItem_Click);
            // 
            // engineeringToolStripMenuItem
            // 
            this.engineeringToolStripMenuItem.Name = "engineeringToolStripMenuItem";
            this.engineeringToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.engineeringToolStripMenuItem.Text = "&Инженерный";
            this.engineeringToolStripMenuItem.Click += new System.EventHandler(this.engineeringToolStripMenuItem_Click);
            // 
            // KeyQuadraticEq
            // 
            this.KeyQuadraticEq.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.KeyQuadraticEq.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyQuadraticEq.ForeColor = System.Drawing.Color.Red;
            this.KeyQuadraticEq.Image = global::SimpleCalculator.Properties.Resources.QuadraticEq;
            this.KeyQuadraticEq.Location = new System.Drawing.Point(200, 240);
            this.KeyQuadraticEq.Name = "KeyQuadraticEq";
            this.KeyQuadraticEq.Size = new System.Drawing.Size(88, 40);
            this.KeyQuadraticEq.TabIndex = 29;
            this.toolTip1.SetToolTip(this.KeyQuadraticEq, "Решение квадратного уравнения");
            this.KeyQuadraticEq.UseVisualStyleBackColor = false;
            this.KeyQuadraticEq.Visible = false;
            this.KeyQuadraticEq.Click += new System.EventHandler(this.KeyQuadraticEq_Click);
            // 
            // KeyFactorial
            // 
            this.KeyFactorial.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.KeyFactorial.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFactorial.ForeColor = System.Drawing.Color.Red;
            this.KeyFactorial.Image = global::SimpleCalculator.Properties.Resources.Factorial;
            this.KeyFactorial.Location = new System.Drawing.Point(248, 192);
            this.KeyFactorial.Name = "KeyFactorial";
            this.KeyFactorial.Size = new System.Drawing.Size(40, 40);
            this.KeyFactorial.TabIndex = 28;
            this.toolTip1.SetToolTip(this.KeyFactorial, "Факториал");
            this.KeyFactorial.UseVisualStyleBackColor = false;
            this.KeyFactorial.Visible = false;
            this.KeyFactorial.Click += new System.EventHandler(this.KeyFactorial_Click);
            // 
            // KeyReverse
            // 
            this.KeyReverse.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.KeyReverse.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyReverse.ForeColor = System.Drawing.Color.Red;
            this.KeyReverse.Image = global::SimpleCalculator.Properties.Resources.Reverse;
            this.KeyReverse.Location = new System.Drawing.Point(200, 192);
            this.KeyReverse.Name = "KeyReverse";
            this.KeyReverse.Size = new System.Drawing.Size(40, 40);
            this.KeyReverse.TabIndex = 27;
            this.toolTip1.SetToolTip(this.KeyReverse, "Расчет обратного значения");
            this.KeyReverse.UseVisualStyleBackColor = false;
            this.KeyReverse.Visible = false;
            this.KeyReverse.Click += new System.EventHandler(this.KeyReverse_Click);
            // 
            // KeyCubeRoot
            // 
            this.KeyCubeRoot.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.KeyCubeRoot.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyCubeRoot.ForeColor = System.Drawing.Color.Red;
            this.KeyCubeRoot.Image = global::SimpleCalculator.Properties.Resources.CubeRoot;
            this.KeyCubeRoot.Location = new System.Drawing.Point(248, 144);
            this.KeyCubeRoot.Name = "KeyCubeRoot";
            this.KeyCubeRoot.Size = new System.Drawing.Size(40, 40);
            this.KeyCubeRoot.TabIndex = 26;
            this.toolTip1.SetToolTip(this.KeyCubeRoot, "Извлечение кубического корня");
            this.KeyCubeRoot.UseVisualStyleBackColor = false;
            this.KeyCubeRoot.Visible = false;
            this.KeyCubeRoot.Click += new System.EventHandler(this.KeyCubeRoot_Click);
            // 
            // KeySqrt
            // 
            this.KeySqrt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.KeySqrt.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySqrt.ForeColor = System.Drawing.Color.Red;
            this.KeySqrt.Image = global::SimpleCalculator.Properties.Resources.Sqrt;
            this.KeySqrt.Location = new System.Drawing.Point(200, 144);
            this.KeySqrt.Name = "KeySqrt";
            this.KeySqrt.Size = new System.Drawing.Size(40, 40);
            this.KeySqrt.TabIndex = 25;
            this.toolTip1.SetToolTip(this.KeySqrt, "Извлечение квадратного корня");
            this.KeySqrt.UseVisualStyleBackColor = false;
            this.KeySqrt.Visible = false;
            this.KeySqrt.Click += new System.EventHandler(this.KeySqrt_Click);
            // 
            // KeySquaring
            // 
            this.KeySquaring.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.KeySquaring.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySquaring.ForeColor = System.Drawing.Color.Red;
            this.KeySquaring.Image = global::SimpleCalculator.Properties.Resources.Squaring;
            this.KeySquaring.Location = new System.Drawing.Point(200, 96);
            this.KeySquaring.Name = "KeySquaring";
            this.KeySquaring.Size = new System.Drawing.Size(40, 40);
            this.KeySquaring.TabIndex = 24;
            this.toolTip1.SetToolTip(this.KeySquaring, "Возведение в квадрат");
            this.KeySquaring.UseVisualStyleBackColor = false;
            this.KeySquaring.Visible = false;
            this.KeySquaring.Click += new System.EventHandler(this.KeySquaring_Click);
            // 
            // KeyDegree
            // 
            this.KeyDegree.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.KeyDegree.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyDegree.ForeColor = System.Drawing.Color.Red;
            this.KeyDegree.Image = global::SimpleCalculator.Properties.Resources.Exponentiation;
            this.KeyDegree.Location = new System.Drawing.Point(248, 96);
            this.KeyDegree.Name = "KeyDegree";
            this.KeyDegree.Size = new System.Drawing.Size(40, 40);
            this.KeyDegree.TabIndex = 23;
            this.toolTip1.SetToolTip(this.KeyDegree, "Возведение в степень");
            this.KeyDegree.UseVisualStyleBackColor = false;
            this.KeyDegree.Visible = false;
            this.KeyDegree.Click += new System.EventHandler(this.KeyDegree_Click);
            // 
            // CalcUI
            // 
            this.AcceptButton = this.KeyZero;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(264, 291);
            this.Controls.Add(this.KeyFactorial);
            this.Controls.Add(this.KeyCubeRoot);
            this.Controls.Add(this.KeyDegree);
            this.Controls.Add(this.KeyOne);
            this.Controls.Add(this.KeyTwo);
            this.Controls.Add(this.KeyThree);
            this.Controls.Add(this.KeyFour);
            this.Controls.Add(this.KeyFive);
            this.Controls.Add(this.KeySix);
            this.Controls.Add(this.KeySeven);
            this.Controls.Add(this.KeyEight);
            this.Controls.Add(this.KeyNine);
            this.Controls.Add(this.KeyZero);
            this.Controls.Add(this.KeyPlus);
            this.Controls.Add(this.KeyMinus);
            this.Controls.Add(this.KeyMultiply);
            this.Controls.Add(this.KeyDivide);
            this.Controls.Add(this.KeySign);
            this.Controls.Add(this.KeyPoint);
            this.Controls.Add(this.KeyEqual);
            this.Controls.Add(this.KeyDate);
            this.Controls.Add(this.KeyClear);
            this.Controls.Add(this.KeyExit);
            this.Controls.Add(this.OutputDisplay);
            this.Controls.Add(this.VersionInfo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.KeySquaring);
            this.Controls.Add(this.KeySqrt);
            this.Controls.Add(this.KeyReverse);
            this.Controls.Add(this.KeyQuadraticEq);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "CalcUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		protected void KeyPlus_Click (object sender, System.EventArgs e)
		{
			CalculatorEngine.CalcOperation (CalculatorEngine.Operator.eAdd);
		}

		protected void KeyMinus_Click (object sender, System.EventArgs e)
		{
			CalculatorEngine.CalcOperation (CalculatorEngine.Operator.eSubtract);
		}

		protected void KeyMultiply_Click (object sender, System.EventArgs e)
		{
			CalculatorEngine.CalcOperation (CalculatorEngine.Operator.eMultiply);
		}

		protected void KeyDivide_Click (object sender, System.EventArgs e)
		{
			CalculatorEngine.CalcOperation (CalculatorEngine.Operator.eDivide);
		}

        private void KeySquaring_Click(object sender, EventArgs e)
        {
            CalculatorEngine.CalcOperation(CalculatorEngine.Operator.eSquaring);
            
        }

        private void KeyDegree_Click(object sender, EventArgs e)
        {
            CalculatorEngine.CalcOperation(CalculatorEngine.Operator.eDegree);
        }

        private void KeySqrt_Click(object sender, EventArgs e)
        {
            CalculatorEngine.CalcOperation(CalculatorEngine.Operator.eSqrt);
        }

        private void KeyCubeRoot_Click(object sender, EventArgs e)
        {
            CalculatorEngine.CalcOperation(CalculatorEngine.Operator.eCubeRoot);
        }

        private void KeyReverse_Click(object sender, EventArgs e)
        {
            CalculatorEngine.CalcOperation(CalculatorEngine.Operator.eReverse);
        }

        private void KeyFactorial_Click(object sender, EventArgs e)
        {
            CalculatorEngine.CalcOperation(CalculatorEngine.Operator.eFactorial);
        }

        //
        // EngineeringForm
        //
        private void engineeringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 372;
            VersionInfo.Width = 346;
            OutputDisplay.Width = 346;

            KeyClear.Location = new System.Drawing.Point(296, 96);
            KeyDate.Location = new System.Drawing.Point(296, 144);
            KeyExit.Location = new System.Drawing.Point(296, 196);
            KeyEqual.Location = new System.Drawing.Point (296, 240);

            KeySquaring.Visible = true;
            KeyDegree.Visible = true;
            KeySqrt.Visible = true;
            KeyCubeRoot.Visible = true;
            KeyReverse.Visible = true;
            KeyFactorial.Visible = true;
            KeyQuadraticEq.Visible = true;
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 280;
            VersionInfo.Width = 248;
            OutputDisplay.Width = 248;

            KeyClear.Location = new System.Drawing.Point(200, 96);
            KeyDate.Location = new System.Drawing.Point(200, 144);
            KeyExit.Location = new System.Drawing.Point(200, 196);
            KeyEqual.Location = new System.Drawing.Point(200, 240);

            KeySquaring.Visible = false;
            KeyDegree.Visible = false;
            KeySqrt.Visible = false;
            KeyCubeRoot.Visible = false;
            KeyReverse.Visible = false;
            KeyFactorial.Visible = false;
            KeyQuadraticEq.Visible = false;
        }

        //
        // Dialog window for quadratic equation
        //

        private void KeyQuadraticEq_Click(object sender, EventArgs e)
        {
            QuadraticEq quadraticEqForm = new QuadraticEq();
            quadraticEqForm.ShowDialog();
        }

        //
        // Other non-numeric key click methods.
        //

        protected void KeySign_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalculatorEngine.CalcSign();
		}

		protected void KeyPoint_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalculatorEngine.CalcDecimal();
		}

		protected void KeyDate_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalculatorEngine.GetDate();
			CalculatorEngine.CalcReset();
		}

		protected void KeyClear_Click (object sender, System.EventArgs e)
		{
			CalculatorEngine.CalcReset();
			OutputDisplay.Text = "0";
		}
        protected void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculatorEngine.CalcReset();
            OutputDisplay.Text = "0";
        }

        //
        // Perform the calculation.
        //

        protected void KeyEqual_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalculatorEngine.CalcEqual();
			CalculatorEngine.CalcReset();
		}

		//
		// Numeric key click methods.
		//

		protected void KeyNine_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalculatorEngine.CalcNumber (nineOut);
		}

		protected void KeyEight_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalculatorEngine.CalcNumber (eightOut);
		}

		protected void KeySeven_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalculatorEngine.CalcNumber (sevenOut);
		}

		protected void KeySix_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalculatorEngine.CalcNumber (sixOut);
		}

		protected void KeyFive_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalculatorEngine.CalcNumber (fiveOut);
		}

		protected void KeyFour_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalculatorEngine.CalcNumber (fourOut);
		}

		protected void KeyThree_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalculatorEngine.CalcNumber (threeOut);
		}

		protected void KeyTwo_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalculatorEngine.CalcNumber (twoOut);
		}

		protected void KeyOne_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalculatorEngine.CalcNumber (oneOut);
		}

		protected void KeyZero_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalculatorEngine.CalcNumber (zeroOut);
		}

		//
		// End the program.
		//

		protected void KeyExit_Click (object sender, System.EventArgs e)
		{
			this.Close();
		}
        protected void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
		static void Main() 
		{
			Application.Run(new CalcUI());
		}
          
    }
}
