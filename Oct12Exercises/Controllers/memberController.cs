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
    public class memberController : ApiController
    {
        // GET: api/member
        membermethods ms = null;
        public memberController()
        {
            ms = new membermethods();
        }
        public List<membermodel> ds = new List<membermodel>();
        [Route("GetAllMembers")]
        public IEnumerable<membermodel> Get()
        {
            List<member> mr = ms.GetMembers();
            foreach (var item in mr) {
                membermodel m = new membermodel();
                m.memberId = Convert.ToInt32(item.member_id);
                m.memberName = item.member_name;
               if(item.maxbooksallowed is DBNull)
                {
                    m.maxbooksallowed = null;
                }
                else
                {
                    m.maxbooksallowed =Convert.ToInt32(item.maxbooksallowed);

                }
                m.Accountopen =Convert.ToDateTime(item.Acc_open_date);
                if(item.penaltyamount is DBNull)
                {
                    m.penaltyamount = null;
                }
                else
                {
                    m.penaltyamount =Convert.ToInt32(item.penaltyamount);
                }
                ds.Add(m);
                    }
            return ds;

        }
        [Route("findmember/{id}")]
        // GET: api/member/5
        public membermodel Get(int id)
        {
            membermodel m = new membermodel();
            member b = ms.findmember(id);
            m.memberId =Convert.ToInt32(b.member_id);
            m.memberName = b.member_name;
            m.Accountopen = Convert.ToDateTime(b.Acc_open_date);
            m.penaltyamount = Convert.ToInt32(b.penaltyamount);
            m.maxbooksallowed = Convert.ToInt32(b.maxbooksallowed);
            return m;


        }
        [Route("addmember")]
        // POST: api/member
        public HttpResponseMessage Post([FromBody]membermodel value)
        {
            member m = new member();
            m.member_id = value.memberId;
            m.member_name = value.memberName;
            m.Acc_open_date = value.Accountopen;
            m.penaltyamount = value.penaltyamount;
            m.maxbooksallowed = value.maxbooksallowed;
            bool k = ms.addmember(m);
            if (k)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }
        }
        [Route("updatemember/{id}")]
        // PUT: api/member/5
        public HttpResponseMessage Put(int id, [FromBody]membermodel value)
        {
            member m = new member();
            m.member_id = value.memberId;
            m.member_name = value.memberName;
            m.Acc_open_date = value.Accountopen;
            m.penaltyamount = value.penaltyamount;
            m.maxbooksallowed = value.maxbooksallowed;
            bool k = ms.updatemember(id,m);
            if (k)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }

        }
        [Route("deletemember/{id}")]
        // DELETE: api/member/5
        public HttpResponseMessage Delete(int id)
        {
            bool k = ms.deletemember(id);
            if (k)
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
