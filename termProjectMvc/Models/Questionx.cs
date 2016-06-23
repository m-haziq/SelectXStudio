using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace termProjectMvc.Models
{
    public class Questionx : IQuestion
    {

        Database1Entities1 db = new Database1Entities1();

       public List<question> show()
        {
            List<question> li = new List<question>();
            li = db.questions.ToList();
            return li;
        }
    }
}