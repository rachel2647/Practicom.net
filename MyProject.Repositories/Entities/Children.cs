using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Entities
{
    public class Children
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public DateTime Birthday { get; set; }
        public string Identity { get; set; }
        [ForeignKey("User")]
        public int IdUser { get; set; }
        public User User { get; set; }
        public Children()
        {

        }
        public Children(int id, string firstName, DateTime birthday, string identity, int parentId, User p)
        {
            Id = id;
            FirstName = firstName;
            Birthday = birthday;
            Identity = identity;
            IdUser = parentId;
            User = p;
        }
    }
}
