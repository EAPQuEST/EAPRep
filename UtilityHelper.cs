using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_Week5.Helper
{
    class UtilityHelper
    {
        public static string GenerateID(string oldId)
        {
            string newId = null;
            string prefix, sufix;
            int next;
            try
            {
                
                prefix = oldId.Substring(0, 3);
                sufix = oldId.Substring(3);
                next = Convert.ToInt32(sufix) + 1;
                newId = prefix + next;
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : UtilityHelper.cs:GenerateID()", ex.Message.ToString());
            }
            return newId;
        }
    }
}
