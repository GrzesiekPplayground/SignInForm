using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Data.OleDb;

namespace SignInForm {

    abstract class AbstractPerson
    {

        public AbstractPerson(string name)
        {
        }

        //Pass in all the information
        public AbstractPerson(int id, string name, string city, string email, string phone)
        {
        }

        abstract public int id();
        abstract public string name();
        abstract public string city();
        abstract public string email();
        abstract public string phone();

        //Abstract methods
        abstract public void UpdateContact(string newEmail);

        abstract public void UpdateContact(string newEmail, string newPhone);

        abstract public void GetBasicInfo(string name, ref string[] basicInfo);

        abstract public void GetContact();
    }
}
