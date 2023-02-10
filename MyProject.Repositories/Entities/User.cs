using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Entities
{
    public enum eGender { Male,Female};
    public enum eHOM { Maccabi,Meuhedet,Clalit,Leumit};
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Identity { get; set; }
        public DateTime Birthday { get; set; }
        public eGender Gender { get; set; }
        public eHOM HOM { get; set; }
        public User()
        {

        }
        public User(int id,string firstName, string lastName, string identity, DateTime birthday, eGender gender, eHOM hOM)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Identity = identity;
            Birthday = birthday;
            Gender = gender;
            HOM = hOM;
        }
    }
}
