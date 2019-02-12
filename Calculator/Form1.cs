using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public enum MathOp : byte { Add, Sub, Mult, Div };
        MathOp Operation;
        string opA = "";
        string opB = "";
        decimal res;
        bool isZero;
        bool isAfterResult;
        bool isPendingOp; //operation        
        

        public Form1()
        {
            InitializeComponent();
            ResetBools();
        }
        

        private void BtnC_Click(object sender, EventArgs e)
        {
            ResetBools();
            ResetOperands();
            LblDisplay.Text = "0";
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            if (isPendingOp)
            {
                opB = "";
                LblDisplay.Text = "0";
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (isZero)
            {
                int n = opA.Length;
                opA = opA.Substring(0, n-1);
            }
            else
            {
                int n = opB.Length;
                opB = opB.Substring(0, n-1);
            }
            PrintNumber();
        }

        private void BtnEq_Click(object sender, EventArgs e)
        {
            if (isPendingOp)
            {
                DoCalculation();
                isAfterResult = true;
            }
        }       

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Operation = MathOp.Add;
            MathOpLogic();
            isPendingOp = true;
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            Operation = MathOp.Sub;
            MathOpLogic();
            isPendingOp = true;
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            Operation = MathOp.Mult;
            MathOpLogic();
            isPendingOp = true;
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            Operation = MathOp.Div;
            MathOpLogic();
            isPendingOp = true;
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (isAfterResult)
            {
                ResetBools();
                ResetOperands();
            }
            if (isZero)
            {
                if (opA != "" && opA != "0")
                {
                    opA += 0;
                    PrintNumber();
                }                    
            }
            else
            {
                if (opB != "" && opB != "0")
                {
                    opB += 0;
                    PrintNumber();
                }                    
            }
            
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (isAfterResult)
            {
                ResetBools();
                ResetOperands();
            }
            if (isZero)
            {
                opA += 1;
            }
            else
            {
                opB += 1;
            }
            PrintNumber();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (isAfterResult)
            {
                ResetBools();
                ResetOperands();
            }
            if (isZero)
            {
                opA += 2;
            }
            else
            {
                opB += 2;
            }
            PrintNumber();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (isAfterResult)
            {
                ResetBools();
                ResetOperands();
            }
            if (isZero)
            {
                opA += 3;
            }
            else
            {
                opB += 3;
            }
            PrintNumber();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (isAfterResult)
            {
                ResetBools();
                ResetOperands();
            }
            if (isZero)
            {
                opA += 4;
            }
            else
            {
                opB += 4;
            }
            PrintNumber();
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (isAfterResult)
            {
                ResetBools();
                ResetOperands();
            }
            if (isZero)
            {
                opA += 5;
            }
            else
            {
                opB += 5;
            }
            PrintNumber();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (isAfterResult)
            {
                ResetBools();
                ResetOperands();
            }
            if (isZero)
            {
                opA += 6;
            }
            else
            {
                opB += 6;
            }
            PrintNumber();
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (isAfterResult)
            {
                ResetBools();
                ResetOperands();
            }
            if (isZero)
            {
                opA += 7;
            }
            else
            {
                opB += 7;
            }
            PrintNumber();
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (isAfterResult)
            {
                ResetBools();
                ResetOperands();
            }
            if (isZero)
            {
                opA += 8;
            }
            else
            {
                opB += 8;
            }
            PrintNumber();
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (isAfterResult)
            {
                ResetBools();
                ResetOperands();
            }
            if (isZero)
            {
                opA += 9;
            }
            else
            {
                opB += 9;
            }
            PrintNumber();
        }

        private void PrintNumber()
        {
            LblDisplay.Text = isZero ? opA.ToString() : opB.ToString();
        }

        private void ResetBools()
        {
            isZero = true;
            isAfterResult = false;
            isPendingOp = false;
        }

        private void ResetOperands()
        {
            opA = opB = "";
        }

        private decimal Calculate(decimal a, decimal b)
        {
            decimal result;
            switch (Operation)
            {
                case MathOp.Add:
                    result = a + b;
                    break;
                case MathOp.Sub:
                    result = a - b;
                    break;
                case MathOp.Mult:
                    result = a * b;
                    break;
                case MathOp.Div:
                    if (b > 0) result = a / b;
                    else
                    {
                        MessageBox.Show("Error");
                        result = -1;
                    }
                    break;
                default:
                    result = -1;
                    break;
            }
            return result;
        }

        private void DoCalculation()
        {
            decimal a = Decimal.Parse(opA);
            decimal b = Decimal.Parse(opB);
            res = Calculate(a, b);
            LblDisplay.Text = res.ToString();
            opA = res.ToString();
        }

        private void MathOpLogic()
        {
            if (isAfterResult)
            {
                isAfterResult = false;
                opA = res.ToString();
                opB = "";
            }
            else if (isPendingOp)
            {
                DoCalculation();
            }
            else
            {
                isZero = false;
            }
        }        
    }
}
