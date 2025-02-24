using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace calculator_winforms.AppLogic.Login.Model
{
     
    class LoginModel : ILoginModel
    {
        private readonly ILoginManager _loginManager;
       

      


        public LoginModel(ILoginManager loginManager)
        {
            _loginManager = loginManager;
        }


        //login
        public event Action<bool> LoginGo;
        public event EventHandler<string> LoginFailed;


        public void LogInApl(string _login, string _password)
        {
            try
            {
                if (_loginManager.Login(_login, _password))
                {
                    LoginGo.Invoke(true);
                }
                else
                {
                    LoginGo.Invoke(true);
                }
            }
            catch (Exception exception)
            {
                LoginFailed?.Invoke(this, exception.Message);
            }

        }

    }
}
