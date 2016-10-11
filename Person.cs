using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Data.OleDb;

namespace SignInForm {

    public class Person
    {
        private int _id;
        private string _name;
        private string _city = _defaultCity;
        private string _email;
        private string _phone;
        /*private string _university = _defaultUniversity;
        private string _fieldOfStudy;
        private string _department;
        private string _yearOfStudy;*/

        public Person(string name)
        {
        }

        public int id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string city
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }

        public string email
        {
            get
            {
                return _email;
            }

            set
            {
                if (!(value.Contains("@")))
                {
                    throw new ArgumentException(
                        "Uncorrect email format!");
                }
                _email = value;
            }
        }

        public string phone
        {
            get
            {
                return _phone;
            }

            set
            {
                _phone = value;
            }
        }

        private static string _defaultCity = "Krakow";
        public static string defaultCity
        {
            get { return _defaultCity; }
            set { _defaultCity = value; }
        }

        public void UpdateContact(string newEmail)
        {
            _email = newEmail;
        }

        public void UpdateContact(string newEmail, string newPhone)
        {
            _email = newEmail;
            _phone = newPhone;
        }

        public void GetBasicInfo(string name, ref string[] basicInfo)
        {
            basicInfo[0] = _name;
            basicInfo[1] = _email;
            basicInfo[2] = _city;
        }

        public void GetContact()
        {
            Console.WriteLine(String.Format("name: {0}. e-mail: {1}. phone {2}.", _name, _email, _phone));
        }
    }
}
