using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    public class Authorization
    {
        /// <summary>
        /// Этот метод проверяет логин и пароль и возвращает true или false
        /// </summary>
        /// <param name="login">логин</param>
        /// <param name="password">пароль</param>
        /// <returns>результат проверки</returns>
        static public bool AuthCheck(string login, string password)
        {
            if (login == "root" && password == "GeekBrains")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
