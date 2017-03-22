using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRF.Controller
{
    class FormController
    {
        /// <summary>
        /// Konvertering af romertal til decimal tal
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public decimal[] RomanToValue(string value)
        {
            List<decimal> listValues = new List<decimal>();

             foreach(var i in value)
            {
                switch (i)
                {
                    case 'I':
                        listValues.Add(1);
                        break;
                    case 'V':
                        listValues.Add(5);
                        break;
                    case 'X':
                        listValues.Add(10);
                        break;
                    case 'L':
                        listValues.Add(50);
                        break;
                    case 'C':
                        listValues.Add(100);
                        break;
                    case 'D':
                        listValues.Add(500);
                        break;
                    case 'M':
                        listValues.Add(1000);
                        break;
                }
            }
            return listValues.ToArray();
        }
        
    }
}

