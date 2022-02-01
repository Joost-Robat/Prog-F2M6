using System;
using System.Collections.Generic;
using System.Text;

namespace Database___prog
{
    public class Person : BasePerson
    {
        public Person()
        {
            
        }
        public override void SetName(string name)
        {
            this.name = name;
        }
        public override void SetAge(string age)
        {
            this.age = age;
        }
        public override void SetRole(string role)
        {
            this.role = role;
        }
        public override string GetName()
        {
            return name;
        }
        public override string GetAge()
        {
            return age;
        }
        public override string GetRole()
        {
            return role;
        }
    }
}
