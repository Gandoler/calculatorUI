using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_winforms
{
    public partial class calculator : Form
    {
        public const int MAXSIZE = 10;
        
           

        float a =0, b=0, res=0;

        int operation = 0;
        public calculator()
        {
            InitializeComponent();
        }

        private void guna2CircleButton8_Click(object sender, EventArgs e)
        {
            if ((displaychik.Text.Length <= MAXSIZE))
            {
                displaychik.Text = displaychik.Text + Button_8.Text;
            }
        }

        private void calculator_Load(object sender, EventArgs e)
        {


        }
        private void check_nul_first_displaychik()
        {
            if ((displaychik.Text.Length == 1) && (displaychik.Text == "0"))
            {
                displaychik.Text = "";

            }
        }

        private void Button_0_Click(object sender, EventArgs e)
        {
            if (!(displaychik.Text.Length == 0) && (displaychik.Text.Length <= MAXSIZE))
            {
                displaychik.Text = displaychik.Text + Button_0.Text;
            }
        }

        private void Button_3_Click(object sender, EventArgs e)
        {
            if ((displaychik.Text.Length <= MAXSIZE))
            {
                displaychik.Text = displaychik.Text + Button_3.Text;
            }
        }

        private void Button_2_Click(object sender, EventArgs e)
        {
            if ((displaychik.Text.Length <= MAXSIZE))
            {
                displaychik.Text = displaychik.Text + Button_2.Text;
            }
        }

        private void Button_4_Click(object sender, EventArgs e)
        {
            if ((displaychik.Text.Length <= MAXSIZE))
            {
                displaychik.Text = displaychik.Text + Button_4.Text;
            }
        }

        private void Button_5_Click(object sender, EventArgs e)
        {
            if ((displaychik.Text.Length <= MAXSIZE))
            {
                displaychik.Text = displaychik.Text + Button_5.Text;
            }
        }

        private void Button_6_Click(object sender, EventArgs e)
        {
            if ((displaychik.Text.Length <= MAXSIZE))
            {
                displaychik.Text = displaychik.Text + Button_6.Text;
            }
        }

        private void Button_7_Click(object sender, EventArgs e)
        {
            if ((displaychik.Text.Length <= MAXSIZE))
            {
                displaychik.Text = displaychik.Text + Button_7.Text;
            }
        }

        private void Button_9_Click(object sender, EventArgs e)
        {
            if ((displaychik.Text.Length <= MAXSIZE))
            {
                displaychik.Text = displaychik.Text + Button_9.Text;
            }
        }

        private void Button_plus_Click(object sender, EventArgs e)
        {
            a = float.Parse(displaychik.Text);
            displaychik.Text = "";
            res = a;
            operation = 1;
        }

        private void Button_minus_Click(object sender, EventArgs e)
        {
            a = float.Parse(displaychik.Text);
            displaychik.Text = "";
            res = a;
            operation = 2;
        }

        private void Button_multiple_Click(object sender, EventArgs e)
        {

        }

        private void Button_1_Click(object sender, EventArgs e)
        {
            if ((displaychik.Text.Length <= MAXSIZE))
            {
                displaychik.Text = displaychik.Text + Button_1.Text;
            }
        }

        private void Button_devide_Click(object sender, EventArgs e)
        {
            a = float.Parse(displaychik.Text);
            displaychik.Text = "";
            res = a;
            operation = 3;
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            displaychik.Text = "";
            operation = 0;
        }

        private void check_type_float_or_void_and_print()
        {
            if (res % 1 == 0) 
            {
                displaychik.Text = ((int)res).ToString(); 
            }
            else
            {
                displaychik.Text = res.ToString(); 
            }
        }

        private void Button_equal_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case 0:
                    break;
                case 1:
                    b = float.Parse(displaychik.Text);
                    res = a + b;
                    check_type_float_or_void_and_print();
                    operation = 0;
                    break;
                case 2:
                    b = float.Parse(displaychik.Text);
                    res = a - b;
                    check_type_float_or_void_and_print();
                    operation = 0;
                    break;
                case 3:
                    b = float.Parse(displaychik.Text);
                    res = a / b;
                    check_type_float_or_void_and_print();
                    operation = 0;
                    break;

            }
        }
    }
}
