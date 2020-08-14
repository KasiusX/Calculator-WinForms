using CalculatorLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
            this.Focus();
        }
        
        private void AddToResultButtons_Click(object sender, EventArgs e)
        {
            Button pressedButton = (Button)sender;
            AddToResult(pressedButton.Text);
        }

         private void AddCalculationButtons_Click(object sender, EventArgs e)
        {
            Button pressedButton = (Button)sender;
            manager.AddCalculation(float.Parse(resultLabelValue.Text), pressedButton.Text);
                        
            SetPreviousNumber(manager.Result, pressedButton.Text);

            SetResultNumber();
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

        private void deleteOneNumberButton_Click(object sender, EventArgs e)
        {
            DeleteOne();
        }

        private void deleteCurrentNumberButton_Click(object sender, EventArgs e)
        {
            int startingLength = resultLabelValue.Text.Length;
            for (int i = 0; i < startingLength; i++)
            {
                DeleteOne();
            }
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

        private void equalButton_Click(object sender, EventArgs e)
        {
            manager.AddCalculation(float.Parse(resultLabelValue.Text), "");

            SetResultNumber(manager.Result);
            SetPreviousNumber();

            overwrite = true;
        }

        private void deleteAllButton_Click(object sender, EventArgs e)
        {
            SetResultNumber();
            SetPreviousNumber();
            manager.ResetValues();
        }

        private void negateButton_Click(object sender, EventArgs e)
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

        
    }
}
