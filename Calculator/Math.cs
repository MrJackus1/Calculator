using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using Calculator;

namespace Calculator
{
    class Math
    {
        public string textBox = "";
        public static double Answer;
        public static double Answer2;
        
        //Building String + adding answer variable
        public Math(string x, string Ans)
        {
            if(Ans == "0" )
            {
                textBox = x;
            }
            else
            {
                textBox = Ans + x;
            }
        }
        // Everytime button is pressed, Display needs to be called along with it.
        public string Display()
        {
            string output = "";
            output = textBox;
            return output;
        }
        public void MathStuffAdd(string Text)//Moves first input into storage var, resets screen.
        {
            
            Answer2 = Convert.ToDouble(Text);
            VarClear();
        }

        //space for Minus, Substract and Divide.

        public string MathStuffEquals(string FinalText, string operation)
        {
            if(operation == "+")
            {
                Answer = Answer2 + Convert.ToDouble(FinalText);
            }
            else if(operation == "-")
            {
                Answer = Answer2 - Convert.ToDouble(FinalText);
            }
            else if(operation == "*")
            {
                Answer = Answer2 * Convert.ToDouble(FinalText);
            }
            else if(operation == "/")
            {
                Answer =  Answer2 / Convert.ToDouble(FinalText) ;
            }
            //Answer = Answer2 + Convert.ToDouble(FinalText); saved if IF^^ fucks up
            string outp = Answer.ToString();
            return outp;
        }
        public void ScreenClear()
        {
            textBox = "0";            
        }
        public void VarClear()
        {

            Answer = 0;
            ScreenClear();
           
        }
    





    }
}
