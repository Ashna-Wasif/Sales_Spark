using System.ComponentModel.DataAnnotations;

namespace Sales.Server.Model.Entities
{
    public class Users
    {
        [Key]
        public int user_Id { get; set; }

            public string user_Name { get; set; }

            public string user_Email { get; set; }

            public string user_Contact { get; set; }
            public string user_Password { get; set; }
            public int user_AccessLevel { get; set; }


        }
    }

