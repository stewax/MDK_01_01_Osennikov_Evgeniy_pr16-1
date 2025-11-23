using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Submission_of_Applications_Осенников.RegexC
{
    public class Check
    {
        public static bool CheckReg(string input, string need)
        {
            Match m = Regex.Match(input, need);
            return m.Success;
        }
    }
}
