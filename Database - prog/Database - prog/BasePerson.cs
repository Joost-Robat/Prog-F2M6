using System;
using System.Collections.Generic;
using System.Text;

namespace Database___prog
{
    public abstract class BasePerson
    {
        protected string name;
        protected string age;
        protected string role;
        public BasePerson()
        {

        }
        public abstract void SetName(string name);
        public abstract void SetAge(string age);
        public abstract void SetRole(string role);
        public abstract string GetName();
        public abstract string GetAge();
        public abstract string GetRole();
    }
}
