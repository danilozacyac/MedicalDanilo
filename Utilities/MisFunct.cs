using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Utilities
{
    public class MisFunct
    {
        /// <summary>
        /// Verifica que la cadena que se ingreso como e-mail tenga un patrón válido
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsEmail(string email)
        {
            return (Regex.IsMatch(email, Constants.MatchEmailPattern) == true || email.Equals("")) ? true : false;
        }

        /// <summary>
        /// Verifica que el caracter ingresado sea un caracter numérico
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsADigit(string text)
        {
            Regex regex = new Regex("[^0-9.-]+"); //regex that matches disallowed text 
            return regex.IsMatch(text);
        }
    }
}
