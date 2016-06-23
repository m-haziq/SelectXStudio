using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace termProjectMvc.Models
{
    public class SignRepo : ISign
    {
        public int Id { get; set; }
        [DisplayName("Name")]
        [Required(ErrorMessage = "Enter the Username...!!!")]
        public string username { get; set; }
        [Required(ErrorMessage = "Enter the Password...!!!")]
        public string password { get; set; }
        [DisplayName("Email :")]
        [Required(ErrorMessage = "field Required...!!!")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string email { get; set; }
        public void save(user1 u)
        {
            Database1Entities1 cx = new Database1Entities1();
            cx.user1.Add(u);
            cx.SaveChanges();   
        }
        public void saveC(company u)
        {
            Database1Entities1 cx = new Database1Entities1();
            cx.companies.Add(u);
            cx.SaveChanges();
        }
    }
}