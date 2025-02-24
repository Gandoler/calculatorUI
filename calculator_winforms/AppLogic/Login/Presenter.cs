using calculator_winforms.AppLogic.Login.Model;
using calculator_winforms.AppLogic.Login.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


            #region LoginPageConstr
           


            // Exit button
            _loginView.ExitButtonClick += LoginView_ExitButtonClick;
            _loginView.ExitButtonEntered += LoginView_ExitButtonEntered;
            _loginView.ExitButtonLeavd += LoginView_ExitButtonLeavd;

            // Login button
            _loginView.LoginButtonClick += LoginView_LoginButtonClick;

            #region ModelConstruct
            // Model
            _imodelka = imodelka ?? throw new ArgumentNullException(nameof(imodelka));

            // registration
            _imodelka.UserExist += Imodelka_UserExist;
            _imodelka.UserDidntExist += _imodelka_UserDidntExist;
            _imodelka.UserRegistered += Imodelka_UserRegistered;
            _imodelka.UserNotRegistered += Imodelka_UserNotRegistered;

            //login
            _imodelka.LogMismatch += Imodelka_LogMismatch;
            _imodelka.LoginFailed += Imodelka_LoginFailed;
            _imodelka.LoginGo += Imodelka_LoginGo;

            #endregion
        }

        private void LoginView_LoginButtonClick(object sender, (string, string) e)
        {
            throw new NotImplementedException();
        }

        private void LoginView_ExitButtonLeavd()
        {
            throw new NotImplementedException();
        }

        private void LoginView_ExitButtonEntered()
        {
            throw new NotImplementedException();
        }

        private void LoginView_ExitButtonClick()
        {
            throw new NotImplementedException();
        }
    }
}
