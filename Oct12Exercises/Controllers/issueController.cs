using HelperLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL;
using HelperLibrary;
using Oct12Exercises.Models;

namespace Oct12Exercises.Controllers
{
    public class issueController : ApiController
    {
        issuemethods iis=null;
        public issueController()
        {
            iis = new issuemethods();
        }
        List<Issuemodel> u1 = new List<Issuemodel>();
        // GET: api/issue
        [Route("GetAllIssues")]
        public IEnumerable<Issuemodel> Get()
        {
            List<Issue> cs = iis.GetIssues();
            foreach(var item in cs)
            {
                Issuemodel I2 = new Issuemodel();
                I2.issueid =Convert.ToInt32(item.Lib_Issue_Id);
                I2.memberid = Convert.ToInt32(item.Member_Id);
                I2.Bookid = Convert.ToInt32(item.Book_No);
                I2.issuedate = Convert.ToDateTime(item.Issue_Date);
                I2.returndate = Convert.ToDateTime(item.Return_date);
                I2.comments = item.comments;
                u1.Add(I2);

              
            }
            return u1;
        }
        [Route("Findissue/{id}")]
        // GET: api/issue/5
        public Issuemodel Get(int id)
        {
           Issue k = iis.findissue(id);
            Issuemodel I2 = new Issuemodel();
            I2.issueid = Convert.ToInt32(k.Lib_Issue_Id);
            I2.memberid = Convert.ToInt32(k.Member_Id);
            I2.Bookid = Convert.ToInt32(k.Book_No);
            I2.issuedate = Convert.ToDateTime(k.Issue_Date);
            I2.returndate = Convert.ToDateTime(k.Return_date);
            I2.comments = k.comments;
            return I2;

        }
        [Route("AddIssue")]
        // POST: api/issue
        public HttpResponseMessage Post([FromBody]Issuemodel value)
        {
            Issue k = new Issue();
            k.Lib_Issue_Id = value.issueid;
            k.Member_Id = value.memberid;
            k.Book_No = value.Bookid;
            k.Issue_Date = value.issuedate;
            k.Return_date = value.returndate;
            k.comments = value.comments;
            bool i = iis.AddIssue(k);
            if (i)
            {
                return Request.CreateResponse(HttpStatusCode.OK);

            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }
        }

        // PUT: api/issue/5
        [Route("updateissue/{id}")]
        public HttpResponseMessage Put(int id, [FromBody]Issuemodel value)
        {
            Issue k = new Issue();
            k.Lib_Issue_Id = value.issueid;
            k.Member_Id = value.memberid;
            k.Book_No = value.Bookid;
            k.Issue_Date = value.issuedate;
            k.Return_date = value.returndate;
            k.comments = value.comments;
            bool i = iis.updateIssue(id,k);
            if (i)
            {
                return Request.CreateResponse(HttpStatusCode.OK);

            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }
        }

        // DELETE: api/issue/5
        [Route("deleteissue/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            bool i = iis.deleteIssue(id);
            if (i)
            {
                return Request.CreateResponse(HttpStatusCode.OK);

            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }

        }
    }
}
