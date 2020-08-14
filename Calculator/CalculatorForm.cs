using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }
        
        private void AddToResultButtons_Click(object sender, EventArgs e)
        {
            Button pressedButton = (Button)sender;
            AddToResult(pressedButton.Text);
        }

        private void AddToResult(string toAdd)
        {
            int widthBefore = resultLabelValue.Width;
            if (resultLabelValue.Text == "0" && toAdd != ".")
                resultLabelValue.Text = "";
            
            resultLabelValue.Text += toAdd;

            int widthDifference = resultLabelValue.Width - widthBefore;

            resultLabelValue.Location = new Point { X = resultLabelValue.Location.X - widthDifference,Y = resultLabelValue.Location.Y };            
        }   
        
        private void DeleteOne()
        {
            if (resultLabelValue.Text != "")
            {
                int widthBefore = resultLabelValue.Width;

                resultLabelValue.Text = resultLabelValue.Text.Remove(resultLabelValue.Text.Length-1);

                int widthDifference = widthBefore - resultLabelValue.Width;

                resultLabelValue.Location = new Point { X = resultLabelValue.Location.X + widthDifference, Y = resultLabelValue.Location.Y };
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
    }
}
