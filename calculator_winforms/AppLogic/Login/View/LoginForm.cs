using calculator_winforms.AppLogic.Login.View;
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
    public partial class LoginForm: Form, ILoginView
    {
        public LoginForm()
        {
            InitializeComponent();
        }
    }
}
