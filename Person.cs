using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Tuan2
{
    public class Person
    {
        private string id;
        private string email;
        private string number;
        private string name;
        private string address;
        private string cmnd;
        private DateTime dateofbirth;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Number
        {
            get { return number; }
            set { number = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Diachi
        {
            get { return address; }
            set { address = value; }
        }
        public string Cmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }
        public DateTime Dateofbirth
        {
            get { return dateofbirth; }
            set { dateofbirth = value.Date; }
        }
        public Person(string id, string name, string address, string cmnd, DateTime dateofbirth, string email, string number)
        {
            this.id = id;
            this.email = email;
            this.number = number;
            this.name = name;
            this.address = address;
            this.cmnd = cmnd;
            this.dateofbirth = dateofbirth;
        }
        public Person()
        {
            id = email = number = name = address = cmnd = " ";
            dateofbirth = DateTime.Now.Date;
        }
    }
}
