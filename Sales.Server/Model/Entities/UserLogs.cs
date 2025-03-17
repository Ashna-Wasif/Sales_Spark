using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sales.Server.Model.Entities
{
    public class UserLogs
    {
        [Key]
        public int LogID { get; set; } 

        [ForeignKey("Users")]
        public int user_Id{ get; set; }  

       
        public string actionType { get; set; } 

        public string actionDetails { get; set; }  

        public DateTime timestamp { get; set; } = DateTime.Now;  

       
        public string ipAddress { get; set; }  

        public string deviceInfo { get; set; }  

        public virtual Users user { get; set; }  // Navigation property
    }
}
