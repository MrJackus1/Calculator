using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator;

namespace Calculator
{
    public partial class Calculator : Form
    {
        Math calculating;

        //private double Text1, Text2;
        private string oppers;

        public Calculator()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Text1 = Convert.ToDouble(boxAnswer.Text);
            calculating.MathStuffAdd(boxAnswer.Text);
            boxAnswer.Text = calculating.Display();
            oppers = "+";
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            //Text1 = Convert.ToDouble(boxAnswer.Text);
            calculating.MathStuffAdd(boxAnswer.Text);
            boxAnswer.Text = calculating.Display();
            oppers = "-";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            //Text1 = Convert.ToDouble(boxAnswer.Text);
            calculating.MathStuffAdd(boxAnswer.Text);
            boxAnswer.Text = calculating.Display();
            oppers = "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            //Text1 = Convert.ToDouble(boxAnswer.Text);
            calculating.MathStuffAdd(boxAnswer.Text);
            boxAnswer.Text = calculating.Display();
            oppers = "/";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            calculating.VarClear();
            boxAnswer.Text = calculating.Display();
        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            //Text2 = Convert.ToDouble(boxAnswer.Text);
            //Text2 = Text1 + Text2;            ;
            boxAnswer.Text = calculating.MathStuffEquals(boxAnswer.Text, oppers);
        }
        private void btnOne_Click(object sender, EventArgs e)
        {
            calculating = new Math("1", boxAnswer.Text);
            boxAnswer.Text = calculating.Display();              
        }
        private void btnTwo_Click(object sender, EventArgs e)
        {
            calculating = new Math("2", boxAnswer.Text);
            boxAnswer.Text = calculating.Display();
        }
        private void btnThree_Click(object sender, EventArgs e)
        {
            calculating = new Math("3", boxAnswer.Text);
            boxAnswer.Text = calculating.Display();
        }
        private void btnFour_Click(object sender, EventArgs e)
        {
            calculating = new Math("4", boxAnswer.Text);
            boxAnswer.Text = calculating.Display();
        }
        private void btnFive_Click(object sender, EventArgs e)
        {
            calculating = new Math("5", boxAnswer.Text);
            boxAnswer.Text = calculating.Display();
        }
        private void btnSix_Click(object sender, EventArgs e)
        {
            calculating = new Math("6", boxAnswer.Text);
            boxAnswer.Text = calculating.Display();
        }
        private void btnSeven_Click(object sender, EventArgs e)
        {
            calculating = new Math("7", boxAnswer.Text);
            boxAnswer.Text = calculating.Display();
        }
        private void btnEight_Click(object sender, EventArgs e)
        {
            calculating = new Math("8", boxAnswer.Text);
            boxAnswer.Text = calculating.Display();
        }
        private void btnNine_Click(object sender, EventArgs e)
        {
            calculating = new Math("9", boxAnswer.Text);
            boxAnswer.Text = calculating.Display();
        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            calculating = new Math("0", boxAnswer.Text);
            boxAnswer.Text = calculating.Display();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }


        //Keyboard input conversion
        private void keypress_Press(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                calculating = new Math("0", boxAnswer.Text);
                boxAnswer.Text = calculating.Display();
            }
            else if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                calculating = new Math("1", boxAnswer.Text);
                boxAnswer.Text = calculating.Display();
            }
            if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                calculating = new Math("2", boxAnswer.Text);
                boxAnswer.Text = calculating.Display();
            }
            if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                calculating = new Math("3", boxAnswer.Text);
                boxAnswer.Text = calculating.Display();
            }
            if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                calculating = new Math("4", boxAnswer.Text);
                boxAnswer.Text = calculating.Display();
            }
            if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D6)
            {
                calculating = new Math("5", boxAnswer.Text);
                boxAnswer.Text = calculating.Display();
            }
            if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                calculating = new Math("6", boxAnswer.Text);
                boxAnswer.Text = calculating.Display();
            }
            if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                calculating = new Math("7", boxAnswer.Text);
                boxAnswer.Text = calculating.Display();
            }
            if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                calculating = new Math("8", boxAnswer.Text);
                boxAnswer.Text = calculating.Display();
            }
            if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                calculating = new Math("9", boxAnswer.Text);
                boxAnswer.Text = calculating.Display();
            }
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                calculating.VarClear();
                boxAnswer.Text = calculating.Display();
            }
            if (e.KeyCode == Keys.Add)
            {
                calculating.MathStuffAdd(boxAnswer.Text);
                boxAnswer.Text = calculating.Display();
                oppers = "+";
            }
            if (e.KeyCode == Keys.Subtract)
            {
                calculating.MathStuffAdd(boxAnswer.Text);
                boxAnswer.Text = calculating.Display();
                oppers = "-";
            }
            if (e.KeyCode == Keys.Multiply)
            {
                calculating.MathStuffAdd(boxAnswer.Text);
                boxAnswer.Text = calculating.Display();
                oppers = "*";
            }
            if (e.KeyCode == Keys.Divide)
            {
                calculating.MathStuffAdd(boxAnswer.Text);
                boxAnswer.Text = calculating.Display();
                oppers = "/";
            }
            if (e.KeyCode == Keys.Enter)
            {
                boxAnswer.Text = calculating.MathStuffEquals(boxAnswer.Text, oppers);
            }
        }
    }
}
