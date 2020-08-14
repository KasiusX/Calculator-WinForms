using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorLibrary
{
    public class CalculationManager
    {
        public float Result { get; set; } = 0;
        public string ActiveSign { get; set; } = "";

        public void AddCalculation(float number, string sign)
        {
            if (ActiveSign == "")
                Result = number;
            else
            {
                if (ActiveSign == "+")
                    Result += number;
                if (ActiveSign == "-")
                    Result -= number;
                if (ActiveSign == "/")
                {
                    if (number != 0)
                        Result /= number;
                    else
                        MessageBox.Show("Cant divide with zero"); 
                }
                if (ActiveSign == "*")
                    Result *= number;
                
            }
            ActiveSign = sign;
        }

        public void ResetValues()
        {
            ActiveSign = "";
            Result = 0;
        }

    }
}
