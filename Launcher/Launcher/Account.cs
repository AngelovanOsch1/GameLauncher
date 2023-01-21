using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher
{
    internal class Account
    {
        public string username { get; set; };
        public string _id { get; set; }

        public Account(string username, string id)
        {
            this.username = username;
            this._id = id;
        }
    }
}
