using System;
using System.Drawing;
using System.Windows.Forms;

namespace calculator_winforms.AppLogic.Login.View
{
    internal partial class LoginFrom : Form, ILoginView
    {
        public LoginFrom()
        {
            InitializeComponent();
            // Exit button
            ExitButton.Click += (s, e) => ExitButtonClick?.Invoke();
            ExitButton.MouseEnter += (s, e) => ExitButtonEntered?.Invoke();
            ExitButton.MouseLeave += (s, e) => ExitButtonLeavd?.Invoke();
           
            // Login button
            LoginButton.Click += (s, e) => LoginButtonClick?.Invoke(this, (LogintextBox.Text, PasswordTextBox.Text));
        }

        // Exit button
        public event Action ExitButtonClick;
        public event Action ExitButtonEntered;
        public event Action ExitButtonLeavd;

       
        // Login button
        public event EventHandler<(string, string)>  LoginButtonClick;

      

       


        public void MakeExitButtonForeBlack()
        {
            ExitButton.ForeColor = Color.Black;
        }

        public void MakeExitButtonForeRed()
        {
            ExitButton.ForeColor = Color.Red;
        }

     
    }
}
