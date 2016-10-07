using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInForm {

    public class Person
    {
        private int _id;
        private string _name;
        private string _surname;
        private string _email;
        private string _phone;
        private string _university;
        private string _fieldOfStudy;
        private string _department;
        private string _yearOfStudy;

        public Person(string name, string surname)
        {
            _name = name;
            _surname = surname;
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

        public string surname
        {
            get
            {
                return _surname;
            }

            set
            {
                _surname = value;
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

        public string university
        {
            get
            {
                return _university;
            }

            set
            {
                _university = value;
            }
        }

        public string fieldOfStudy
        {
            get
            {
                return _fieldOfStudy;
            }

            set
            {
                _fieldOfStudy = value;
            }
        }

        public string department
        {
            get
            {
                return _department;
            }

            set
            {
                _department = value;
            }
        }

        public string yearOfStudy
        {
            get
            {
                return _yearOfStudy;
            }

            set
            {
                _yearOfStudy = value;
            }
        }

        public string fullName
        {
            get
            {
                return string.Format("{0} {1}", _name, _surname);
            }
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
    }
}
