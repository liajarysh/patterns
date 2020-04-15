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
            IncomeDataAdapter adaper = new IncomeDataAdapter(new IncomDataRealization("UA", "Java Rush Ltd", "John", "Doe", 38, 12345678));

            Console.WriteLine(adaper.getCountryName());
            Console.WriteLine(adaper.getCompanyName());
            Console.WriteLine(adaper.getName());
            Console.WriteLine(adaper.getPhoneNumber());

            Console.ReadKey();
        }

        public class IncomeDataAdapter: Customer, Contact
        {
            IncomeData data;
            public IncomeDataAdapter( IncomeData data)
            {
                this.data = data;
            }

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

        public class IncomDataRealization: IncomeData
        {
            string countryCode { get; set; }
            string company { get; set; }
            string contactFN { get; set; }
            string contactLN { get; set; }
            int countryPhoneCode { get; set; }
            int phoneNumber { get; set; }

            public IncomDataRealization(string countryCode, string company, string contactFN, string contactLN, int countryPhoneCode, int phoneNumber)
            {
                this.countryCode = countryCode;
                this.company = company;
                this.contactFN = contactFN;
                this.contactLN = contactLN;
                this.countryPhoneCode = countryPhoneCode;
                this.phoneNumber = phoneNumber;
            }

            public string getCountryCode()
            {
                return countryCode;
            }
            public string getCompany()
            {
                return company;
            }
            public string getContactFirstName()
            {
                return contactFN;
            }
            public string getContactLastName()
            {
                return contactLN;
            }
            public int getCountryPhoneCode()
            {
                return countryPhoneCode;
            }
            public int getPhoneNumber()
            {
                return phoneNumber;
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
