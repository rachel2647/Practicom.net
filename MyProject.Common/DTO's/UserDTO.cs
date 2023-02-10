using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Common.DTO_s
{
    public enum DTOGender { Male, Female };
    public enum DTOHOM { Maccabi, Meuhedet, Clalit, Leumit }
    public class UserDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Identity { get; set; }
        public DateTime Birthday { get; set; }
        public DTOGender Gender { get; set; }
        public DTOHOM HOM { get; set; }
        public UserDTO()
        {

        }
        public UserDTO(int id, string firstName, string lastName, string identity, DateTime birthday, DTOGender gender, DTOHOM hOM)
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
