using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using WebApplication3.Models;

namespace WebApplication3.Authorization
{
    public class FormAuthProvider
    {
        public bool Autenticate(LoginViewModel model)
        {
            bool result = FormsAuthentication.Authenticate(model.Name, model.Password);

            if (result)
            {
                FormsAuthentication.SetAuthCookie(model.Name, false);
            }
            return result;
        }
    }
}