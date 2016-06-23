using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using termProjectMvc.Models;

namespace termProjectMvc.Controllers
{
    public class CreateTestModel
    {
        public int technologyID { get; set; }
        public int companyID { get; set; }

    }
    public class AddQuestionModel
    {
        public int testID { get; set; }
        public string statement { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string option3 { get; set; }
        public string option4 { get; set; }
        public int answer { get; set; }
    }

    public class ActivityController : ApiController
    {
        //
        // GET: /Admin/
        Database1Entities1 cx = new Database1Entities1();
        


        [System.Web.Http.HttpGet]
        public HttpResponseMessage CreateTest(int companyID , int technologyID)
        {
            test t = new test() {
                CompanyId = companyID,
                technologyId = technologyID
            };
            cx.tests.Add(t);
            cx.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, new { Status = true, Response = "success",testID = t.Id });
        }


        [System.Web.Http.HttpPost]

        public HttpResponseMessage AddQuestion(AddQuestionModel model)
        {

            question t = new question()
            {
                testId = model.testID,
                statement = model.statement,
                answer = model.answer,
                option1 = model.option1,
                option2 = model.option2,
                option3 = model.option3,
                option4 = model.option4
            };
            cx.questions.Add(t);
            cx.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, new { Status = true, Response = "success", testID = t.Id });
        }


    }
}
