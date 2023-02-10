namespace MyProject.WebApi.Models
{
    public class ChildrenModel
    {
        public string FirstName { get; set; }
        public DateTime Birthday { get; set; }
        public string Identity { get; set; }
        public int IdParent { get; set; }
        public ChildrenModel()
        {

        }
        public ChildrenModel(string firstName, DateTime birthday, string identity, int idParent)
        {
            FirstName = firstName;
            Birthday = birthday;
            Identity = identity;
            IdParent = idParent;
        }
    }
}
