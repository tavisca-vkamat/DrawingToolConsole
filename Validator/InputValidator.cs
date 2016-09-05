using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validator
{
    public class InputValidator
    {
        public static bool IsInt(string inputString,ref int number)
        {
            bool result;

            result = int.TryParse(inputString, out number);
            return result;
        }
    }
}
