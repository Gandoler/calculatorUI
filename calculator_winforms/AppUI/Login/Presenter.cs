using calculator_winforms.AppLogic.Login.Model;
using calculator_winforms.AppLogic.Login.View;
using calculator_winforms.AppLogic.MainPage.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_winforms.AppLogic.Login
{
    class Presenter
    {
        private readonly ILoginView _loginView;
        private readonly ILoginModel _imodelka;



        public Presenter(ILoginView loginView, ILoginModel imodelka)
        {
            _loginView = loginView;
            _imodelka = imodelka;


           


            // Exit button
            _loginView.ExitButtonClick += LoginView_ExitButtonClick;
            _loginView.ExitButtonEntered += LoginView_ExitButtonEntered;
            _loginView.ExitButtonLeavd += LoginView_ExitButtonLeavd;

            // Login button
            _loginView.LoginButtonClick += LoginView_LoginButtonClick;

            
            //login
            
            _imodelka.LoginFailed += Imodelka_LoginFailed;
            _imodelka.LoginGo += Imodelka_LoginGo;

        }

        private void Imodelka_LoginGo(bool obj)
        {
            throw new NotImplementedException();
        }

        private void Imodelka_LoginFailed(object sender, string e)
        {
            MessageBox.Show("Unexpected Error", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LoginView_LoginButtonClick(object sender, (string, string) e)
        {
            _imodelka.LogInApl(e.Item1,e.Item2);
        }

        private void LoginView_ExitButtonLeavd()
        {
            _loginView.MakeExitButtonForeBlack();
        }

        private void LoginView_ExitButtonEntered()
        {
            _loginView.MakeExitButtonForeRed();
        }

        private void LoginView_ExitButtonClick()
        {
            Application.Exit();
        }
    }
}

