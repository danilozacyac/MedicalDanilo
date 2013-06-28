using System;
using System.Linq;

namespace Utilities
{
    public class Constants
    {
        /// <summary>
        /// Patrón regex de válidez de dirección de correo
        /// </summary>
        public const string MatchEmailPattern = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@" +
                                                @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])\." +
                                                @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|" +
                                                @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";

        /// <summary>
        /// Description
        ///  Password entre 8 and 20 caracteres; debe contener una letra minúscula, una mayúscula, 
        /// un número, y un caracter especial, no puede contener espacios en blanco
        /// </summary>
        public const String StrongPass = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z0-9])(?!.*\s).{8,20}$";

    }
}
