using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyProject.Common.DTO_s
{
    public class ChildrenDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public DateTime Birthday { get; set; }
        public string Identity { get; set; }
        [ForeignKey("User")]
        public int IdUser { get; set; }
        public UserDTO User { get; set; }
        public ChildrenDTO()
        {

        }
        public ChildrenDTO(int id, string firstName, DateTime birthday, string identity, int idParent, UserDTO parent)
        {
            Id = id;
            FirstName = firstName;
            Birthday = birthday;
            Identity = identity;
            IdUser = idParent;
            User = parent;
        }
    }
}
