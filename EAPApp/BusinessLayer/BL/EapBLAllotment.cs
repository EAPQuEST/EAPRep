using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransactionObject.DTO;
using DataServiceLayer.DataLayer;
using System.Data;

namespace BusinessLayer.BL
{
    public class EapBLAllotment
    {
        //to get the details according to a row from the allotted details
        public static int FetchByRow()
        {
            int output = 0;
            try
            {

                output = EapDSLAllotment.FetchByRow();

            }
            catch(Exception ex)
            {
                Console.WriteLine("EapBLAllotment.FetchByRow()");
            }
            


            
            return output;

        }

    }
}
