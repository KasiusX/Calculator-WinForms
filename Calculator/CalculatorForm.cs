using CalculatorLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        CalculationManager manager = new CalculationManager();
        bool overwrite = false;
        public CalculatorForm()
        {
            InitializeComponent();
        }
        
        private void AddToResultButtons_Click(object sender, EventArgs e)
        {
            if (e.GetType().Name == "MouseEventArgs")
            {
                Button pressedButton = (Button)sender;
                AddToResult(pressedButton.Text);
            }
        }

         private void AddCalculationButtons_Click(object sender, EventArgs e)
        {
            if (e.GetType().Name == "MouseEventArgs")
            {
                Button pressedButton = (Button)sender;
                AddCalculation(pressedButton.Text);
            }
        }        

        private void deleteAllButton_Click(object sender, EventArgs e)
        {
            
            if (e.GetType().Name == "MouseEventArgs")
            {
                DeleteAll();
            }
        }

        private void negateButton_Click(object sender, EventArgs e)
        {
            if (e.GetType().Name == "MouseEventArgs")
            {
                NegatePressed();
            }
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            if (e.GetType().Name == "MouseEventArgs")
            {
                EqualPressed();
            }
        }
        private void deleteOneNumberButton_Click(object sender, EventArgs e)
        {
            if (e.GetType().Name == "MouseEventArgs")
                DeleteOne();
        }

        private void deleteCurrentNumberButton_Click(object sender, EventArgs e)
        {
            if (e.GetType().Name == "MouseEventArgs")
                DeleteCurrentNumber();
        }        
        
        private void DeleteOne()
        {
            if (resultLabelValue.Text != "")
            {
                int widthBefore = resultLabelValue.Width;
                resultLabelValue.Text = resultLabelValue.Text.Remove(resultLabelValue.Text.Length-1);
                MoveLabel(widthBefore, resultLabelValue.Width, resultLabelValue);
                
                if (resultLabelValue.Text == "")
                    AddToResult("0");
            }
        }
            
        private void DeleteCurrentNumber()
        {
            int startingLength = resultLabelValue.Text.Length;
            for (int i = 0; i < startingLength; i++)
            {
                DeleteOne();
            }
        }

        private void DeleteAll()
        {
            SetResultNumber();
            SetPreviousNumber();
            manager.ResetValues();
        }

        private void SetPreviousNumber(float number = 0, string sign = null)
        {
            int widthBefore = preivousNumberLabel.Width;
            preivousNumberLabel.Text = $"{number}{sign}";
            MoveLabel(widthBefore, preivousNumberLabel.Width, preivousNumberLabel);
        }

        private void SetResultNumber(float number = 0)
        {
            int widthBefore = resultLabelValue.Width;            
            resultLabelValue.Text = number.ToString();
            MoveLabel(widthBefore, resultLabelValue.Width, resultLabelValue);
        }

        private void MoveLabel(int widthBefore, int widthNow, Label label)
        {
            if(widthBefore> widthNow)
            {
                int widthDiff = widthBefore - widthNow;
                label.Location = new Point { X = label.Location.X + widthDiff, Y = label.Location.Y };
            }
            if(widthBefore < widthNow)
            {
                int widthDiff = widthNow - widthBefore;
                label.Location = new Point { X = label.Location.X - widthDiff, Y = label.Location.Y };
            }
        }

        private void AddToResult(string toAdd)
        {
            if ((resultLabelValue.Text == "0" && toAdd != ".") || overwrite)
            {
                SetResultNumber(float.Parse(toAdd));
                overwrite = false;
            }
            else
            {
                int widthBefore = resultLabelValue.Width;
                resultLabelValue.Text += toAdd;
                MoveLabel(widthBefore, resultLabelValue.Width, resultLabelValue);
            }
        }

        private void AddCalculation(string sign)
        {
            manager.AddCalculation(float.Parse(resultLabelValue.Text), sign);

            SetPreviousNumber(manager.Result, sign);

            SetResultNumber();
        }

        private void EqualPressed()
        {
            manager.AddCalculation(float.Parse(resultLabelValue.Text), "");

            SetResultNumber(manager.Result);
            SetPreviousNumber();

            overwrite = true;
        }

        private void NegatePressed()
        {
            if (resultLabelValue.Text[0] != '-')
            {
                SetResultNumber(float.Parse($"-{resultLabelValue.Text}"));
            }
            else
            {
                int widthBefore = resultLabelValue.Width;
                resultLabelValue.Text = resultLabelValue.Text.Remove(0, 1);
                MoveLabel(widthBefore, resultLabelValue.Width, resultLabelValue);
            }
        }


        private void KeyDownPress(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Back)
            {
                DeleteOne();
            }
            else if(e.KeyData == Keys.Delete)
            {
                DeleteCurrentNumber();                
            }
            else if(e.KeyData == Keys.Enter)
            {
                EqualPressed();
            }
            else if(e.KeyData == Keys.End)
            {
                DeleteAll();
            }
            else if(e.KeyData == Keys.Insert)
            {
                NegatePressed();
            }
            
        }

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (int.TryParse(e.KeyChar.ToString(),out int pressed) && 9 >= pressed && pressed >= 0)
            {
                AddToResult(e.KeyChar.ToString());
            }
            else if(e.KeyChar == '/' || e.KeyChar == '*' || e.KeyChar == '+' || e.KeyChar == '-')
            {
                AddCalculation(e.KeyChar.ToString());
            }
            else if (e.KeyChar ==',' || e.KeyChar == '.')
            {
                AddToResult(".");
            }
            else if (e.KeyChar == '=')
            {
                EqualPressed();
            }
        }
    }
}
