using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Person
    {
        int id;
        string firstname;
        string lastname;
        string address;
        int age;
        string gender;

        public Person()
        {
            id = 1;
            firstname = "Paweł";
            lastname = "Hofman";
            address = "Oś boh II woj. św 31/10";
            age = 41;
            //gender = "Facet";
        }
                public Person(int id, string firstname, string lastname, string address, int age, string gender)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.age = age;
            this.gender = gender;
        }
        public Person(int id, string firstname, string lastname)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            address = "Zamenhoffa 133";
            age = 18;
        }
        public Person(int id, string firstname)
        {
            this.id = id;
            this.firstname = firstname;



        }
    }
}
