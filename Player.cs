using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignInForm;

namespace SignInForm
{
    class Player : Person
    {
        private string _surname;
        private string _university;
        private string _fieldOfStudy;
        private string _department;
        private string _yearOfStudy;

        public Player(string name) : base(name)
        {
            string[] fullName = name.Split(' ');
            name = fullName[0];
            _surname = fullName[1];
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

    }
}
