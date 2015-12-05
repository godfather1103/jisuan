using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jisuan
{
    public partial class jisuan : Form
    {
        public jisuan()
        {
            InitializeComponent();
        }

        //用于记录两个输入的参数,初始值为0
        double[] Parameter = new double[2] { 0, 0 };
        //是否选择了运算符；是--true，否--false
        bool select_Operator = false;
        //标记选中了哪个运算符 0--加，1--减，2--乘，3--除,4--等于
        int Operator_flag = 4;
        //小数点是否点击过；是--true，否--false
        bool Dot_Clicked = false;

        private void Clean_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "";
            Dot_Clicked = false;
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (select_Operator || ResultBox.Text == null || "".Equals(ResultBox.Text))
            {
                ResultBox.Text = "0";
                select_Operator = false;
            }
            else if(Dot_Clicked||!"0".Equals(ResultBox.Text))
            {
                ResultBox.Text += "0";
            }
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (select_Operator || "0".Equals(ResultBox.Text))
            {
                ResultBox.Text = "1";
                select_Operator = false;
            }
            else
            {
                ResultBox.Text += "1";
            }
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (select_Operator || "0".Equals(ResultBox.Text))
            {
                ResultBox.Text = "2";
                select_Operator = false;
            }
            else
            {
                ResultBox.Text += "2";
            }
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (select_Operator || "0".Equals(ResultBox.Text))
            {
                ResultBox.Text = "3";
                select_Operator = false;
            }
            else
            {
                ResultBox.Text += "3";
            }
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (select_Operator || "0".Equals(ResultBox.Text))
            {
                ResultBox.Text = "4";
                select_Operator = false;
            }
            else
            {
                ResultBox.Text += "4";
            }
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (select_Operator || "0".Equals(ResultBox.Text))
            {
                ResultBox.Text = "5";
                select_Operator = false;
            }
            else
            {
                ResultBox.Text += "5";
            }
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (select_Operator || "0".Equals(ResultBox.Text))
            {
                ResultBox.Text = "6";
                select_Operator = false;
            }
            else
            {
                ResultBox.Text += "6";
            }
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (select_Operator || "0".Equals(ResultBox.Text))
            {
                ResultBox.Text = "7";
                select_Operator = false;
            }
            else
            {
                ResultBox.Text += "7";
            }
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (select_Operator || "0".Equals(ResultBox.Text))
            {
                ResultBox.Text = "8";
                select_Operator = false;
            }
            else
            {
                ResultBox.Text += "8";
            }
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (select_Operator || "0".Equals(ResultBox.Text))
            {
                ResultBox.Text = "9";
                select_Operator = false;
            }
            else
            {
                ResultBox.Text += "9";
            }
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            if (!select_Operator && !Dot_Clicked&&(ResultBox.Text!= null&&!"".Equals(ResultBox.Text))) {
                ResultBox.Text += ".";
                Dot_Clicked = true;
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Parameter[0] = Parameter[1] = 0;
            Operator_flag = 4;
            select_Operator = false;
            Dot_Clicked = false;
            ResultBox.Text = "";
        }

        private void Fallback_Click(object sender, EventArgs e)
        {
            if(ResultBox.Text.Length>0)
            ResultBox.Text = ResultBox.Text.Substring(0, ResultBox.Text.Length - 1);
            if (ResultBox.Text.Length == 1)
                Dot_Clicked = false;
            if(ResultBox.Text.Length == 2&& Dot_Clicked)
            {
                Dot_Clicked = false;
                ResultBox.Text = ResultBox.Text.Substring(0, ResultBox.Text.Length - 1);
            }
        }

        private void Div_Click(object sender, EventArgs e)
        {
            select_Operator = true;
            Operator_flag = 3;
            Parameter[0] = Double.Parse(ResultBox.Text);
            Dot_Clicked = false;
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            select_Operator = true;
            Operator_flag = 2;
            Parameter[0] = Double.Parse(ResultBox.Text);
            Dot_Clicked = false;
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            select_Operator = true;
            Operator_flag = 1;
            Parameter[0] = Double.Parse(ResultBox.Text);
            Dot_Clicked = false;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            select_Operator = true;
            Operator_flag = 0;
            Parameter[0] = Double.Parse(ResultBox.Text);
            Dot_Clicked = false;
        }

        private void Cal_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == null || "".Equals(ResultBox.Text))
                return;
            Parameter[1] = Double.Parse(ResultBox.Text);
            select_Operator = true;
            switch (Operator_flag)
            {
                case 0:
                    ResultBox.Text = (Parameter[0] + Parameter[1]).ToString();
                    break;
                case 1:
                    ResultBox.Text = (Parameter[0] - Parameter[1]).ToString();
                    break;
                case 2:
                    ResultBox.Text = (Parameter[0] * Parameter[1]).ToString();
                    break;
                case 3:
                    if (Parameter[1] == 0)
                        ResultBox.Text = "除数不能为零";
                    else
                    ResultBox.Text = (Parameter[0] / Parameter[1]).ToString();
                    break;
                case 4:
                    break;
            }
            Operator_flag = 4;
        }

        private void Neg_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == null || "".Equals(ResultBox.Text)) ;
            else
            ResultBox.Text = (0.0 -Double.Parse(ResultBox.Text)).ToString();
        }
    }
}
