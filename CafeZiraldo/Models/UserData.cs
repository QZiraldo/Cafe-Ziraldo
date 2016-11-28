using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CafeZiraldo.Models
{
    public class UserData
    {
        private string uname;
        private string email;

        public string Uname
        {
            get
            {
                return uname;
            }

            set
            {
                uname = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
    }
}