using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Solution
    {
        public static Dictionary<String, String> countries = new Dictionary<string, string>();

        public static void Main()
        {
            countries.Add("UA", "Ukraine");
            countries.Add("RU", "Russia");
            countries.Add("CA", "Canada");
            
        }

        public class IncomeDataAdapter: Customer, Contact
        {
            IncomeData data;

            public string getCompanyName()
            {
                return data.getCompany();
            }

            public string getCountryName()
            {                
                return countries[data.getCountryCode()];
            }
            public string getName()
            {
                return data.getContactLastName() + ", " + data.getContactFirstName();
            }
            public string getPhoneNumber()
            {
                string number = data.getPhoneNumber().ToString();
                string correctNumber = "";
                if (number.Length != 10) {
                    for (int i = 0; i < 10 - number.Length; ++i)
                        correctNumber += "0";                    
                        }
                correctNumber += number;
                correctNumber = "(" + correctNumber[0] + correctNumber[1] + correctNumber[2] + ")" + correctNumber[3] + correctNumber[4] + correctNumber[5] + "-" + correctNumber[6] + correctNumber[7] + "-" + correctNumber[8] + correctNumber[9];

                return "+" + data.getCountryPhoneCode() + correctNumber;
            }


        }

        public interface IncomeData
        {
            string getCountryCode();
            string getCompany();
            string getContactFirstName();
            string getContactLastName();
            int getCountryPhoneCode();
            int getPhoneNumber();
        }

        public interface Customer
        {
            string getCompanyName();
            string getCountryName();
        }

        public interface Contact
        {
            string getName();
            string getPhoneNumber();
        }
    }
}
