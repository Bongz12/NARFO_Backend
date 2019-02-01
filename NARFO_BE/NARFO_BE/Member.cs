using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NARFO_BE
{
    public class Member
    {
        private int memberId;
        public int ID
        {
            get { return memberId; }
            set { memberId = value; }
        }

        private string fName;
        public string firstName
        {
            get { return fName; }
            set { fName = value; }
        }

        private string lName;
        public string lastName
        {
            get { return lName; }
            set { lName = value; }
        }

        private string usrname;
        public string username
        {
            get { return usrname; }
            set { usrname = value; }
        }

        private string passwrd;
        public string password
        {
            get { return passwrd; }
            set { passwrd = value; }
        }
    }
}
