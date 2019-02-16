using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1
{
    static public class Check
    {
        /// <summary>
        /// Метод проверки логина без регулярных выражений
        /// </summary>
        /// <param name="login">логин</param>
        /// <returns>подходит или нет</returns>
        static public bool NoRegular(string login)
        {
            if ((login.Length < 2) || (login.Length > 10) || (char.IsDigit(login[0])))
            {
                return false;
            }
            else
            {
                foreach (char C in login)
                {
                    if (((C >= 'a') && (C <= 'z')) ||
                        ((C >= 'A') && (C <= 'Z')) ||
                        ((C >= '0') && (C <= '9')))
                    {
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;

        }
        /// <summary>
        /// Метод проверки логина c регулярным выражением
        /// </summary>
        /// <param name="login">логин</param>
        /// <returns>подходит или нет</returns>
        static public bool Regular(string login)
        {
            Regex myReg = new Regex(@"^([A-Za-z])([A-Za-z0-9]){1,9}$");
            return myReg.IsMatch(login);
        }
        
    }
}
