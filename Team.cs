using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignInForm;

namespace SignInForm
{
    class Team : Person
    {
        private string _capitan;
        private int _points;
        private object[] _players = { };
        public Team(string name) : base(name)
        {
            name = name;
        }

        public string capitan
        {
            get
            {
                return _capitan;
            }
            set
            {
                _capitan = value;
            }
        }

        public int points
        {
            get
            {
                return _points;
            }
            set
            {
                _points = value;
            }
        }

        public object[] players
        {
            get
            {
                return _players;
            }
            set
            {
                _players = value;
            }
        }
        public new void GetContact()
        {
            Console.WriteLine(String.Format("capita: {0}. name: {1}. e-mail: {2}. phone {3}.", _capitan, name, email, phone));
        }        
    }
}
