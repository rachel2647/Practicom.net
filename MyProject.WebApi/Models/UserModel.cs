using MyProject.Repositories.Entities;

namespace MyProject.WebApi.Models
{
    public enum eGenderModel { Male, Female };
    public enum eHMOModel { Maccabi, Meuhedet, Clalit, Leumit };
    public class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Identity { get; set; }
        public DateTime Birthday { get; set; }
        public eGenderModel Gender { get; set; }
        public eHMOModel HMO { get; set; }
        public UserModel()
        {

        }
        public UserModel(string firstName, string lastName, string identity, DateTime birthday, eGenderModel gender, eHMOModel hMO)
        {
            FirstName = firstName;
            LastName = lastName;
            Identity = identity;
            Birthday = birthday;
            Gender = gender;
            HMO = hMO;
        }
    }
}
