using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_winforms.AppLogic.Login.Model
{
    interface ILoginModel
    {


        //login
         event Action<bool> LoginGo;
         event EventHandler<string> LoginFailed;


         void LogInApl(string _login, string _password);
       
    }
}
