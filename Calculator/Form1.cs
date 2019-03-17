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
    public partial class frmCalculator : Form
    {
        public enum MathOp : byte { Add, Sub, Mult, Div };
        MathOp Operation;
        string opA = "";
        string opB = "";
        decimal res;
        bool isZero;
        bool isAfterResult;
        bool isPendingOp; //operation        
        

        public frmCalculator()
        {
            InitializeComponent();
            ResetBools();
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

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int value = Convert.ToInt32(btn.Text);

            if (isAfterResult)
            {
                ResetBools();
                ResetOperands();
            }
            if (isZero)
            {
                opA += value;
            }
            else
            {
                opB += value;
            }
            PrintNumber();
        }
        
        
        

        #region Operation Buttons
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
                opA = opA.Substring(0, n - 1);
            }
            else
            {
                int n = opB.Length;
                opB = opB.Substring(0, n - 1);
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
        #endregion

        #region Auxiliary Methods
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
        #endregion

    }
}
