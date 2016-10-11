using System;

namespace SignInForm
{
    class TeamMember : AbstractPerson
    {
        public TeamMember(string name) : base(name)
        {
        }
        public override string city()
        {
            throw new NotImplementedException();
        }

        public override string email()
        {
            throw new NotImplementedException();
        }

        public override void GetBasicInfo(string name, ref string[] basicInfo)
        {
            throw new NotImplementedException();
        }

        public override void GetContact()
        {
            throw new NotImplementedException();
        }

        public override int id()
        {
            throw new NotImplementedException();
        }

        public override string name()
        {
            throw new NotImplementedException();
        }

        public override string phone()
        {
            throw new NotImplementedException();
        }

        public override void UpdateContact(string newEmail)
        {
            throw new NotImplementedException();
        }

        public override void UpdateContact(string newEmail, string newPhone)
        {
            throw new NotImplementedException();
        }
    }
}
