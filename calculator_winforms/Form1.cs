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

        

        private void calculator_Load(object sender, EventArgs e)
        {


        }
        

        private void Button_0_Click(object sender, EventArgs e)
        {
            if ((displaychik.Text.Length > 0) && (displaychik.Text.Length <= MAXSIZE) && (displaychik.Text != "-"))
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
           if( displaychik.Text.Length == 0)
            {
                displaychik.Text = "-";
            }
            else {
                if (displaychik.Text == "-")
                {
                    displaychik.Text = "";

                }
                else
                {
                    a = float.Parse(displaychik.Text);
                    displaychik.Text = "";
                    res = a;
                    operation = 2;
                }
                
            }
            
        }

        private void Button_multiple_Click(object sender, EventArgs e)
        {
            if (displaychik.Text == "")
            {
                a = 0;
            }
            else
            {
                a = float.Parse(displaychik.Text);
            }
            displaychik.Text = "";
            res = a;
            operation = 3;
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
            if (displaychik.Text == "")
            {
                a = 0;
            }
            else
            {
                a = float.Parse(displaychik.Text);
            }
            displaychik.Text = "";
            res = a;
            operation = 4;
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            displaychik.Text = "";
            operation = 0;
        }

        private void Button_8_Click(object sender, EventArgs e)
        {
            if ((displaychik.Text.Length <= MAXSIZE))
            {
                displaychik.Text = displaychik.Text + Button_8.Text;
            }
        }

        private void check_type_float_or_void_and_print()
        {
            if (res % 1 == 0) 
            {
                try
                {
                    displaychik.Text = (checked((int)res)).ToString();
                }catch(Exception ex)
                {
                    MessageBox.Show("Ошибка переполнения\n\t\tПодробности:\n" + ex);
                    a = 0;
                    b = 0;
                    operation = 0;
                }
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
                    if (displaychik.Text == "")
                    {
                        b = 0;
                    }
                    else
                    {
                        b = float.Parse(displaychik.Text);
                    }
                    res = a + b;
                    check_type_float_or_void_and_print();
                    operation = 0;
                    break;
                case 2:
                    if (displaychik.Text == "")
                    {
                        b = 0;
                    }
                    else
                    {
                        b = float.Parse(displaychik.Text);
                    }

                    res = a - b;
                    check_type_float_or_void_and_print();
                    operation = 0;
                    break;
                case 3:
                    if (displaychik.Text == "")
                    {
                        b = 0;
                    }
                    else
                    {
                        b = float.Parse(displaychik.Text);
                    }
                    res = a * b;
                    check_type_float_or_void_and_print();
                    operation = 0;
                    break;
                case 4:
                    if (displaychik.Text == "")
                    {
                        b = 0;
                    }
                    else
                    {
                        b = float.Parse(displaychik.Text);
                    }
                    try
                    {
                        res = a / b;
                    }
                    catch (Exception ex) 
                        {
                        MessageBox.Show("Ошибка деления\n\t\tПодробности:\n" + ex);
                        a = 0;
                        b = 0;
                        operation = 0;
                        }
                    check_type_float_or_void_and_print();
                    operation = 0;
                    break;

            }
        }
    }
}
