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
        }
    }
}
