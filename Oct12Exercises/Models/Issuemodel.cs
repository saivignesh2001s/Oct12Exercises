using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Oct12Exercises.Models
{
    public class Issuemodel
    {
        [Required()]
        public int issueid
        {
            get;
            set;
        }
        public int Bookid
        {
            get;
            set;
        }
        public int memberid
        {
            get;
            set;
        }
        public DateTime issuedate
        {
            get;
            set;
        }
        public DateTime returndate
        {
            get;
            set;
        }
        public string comments
        {
            get;
            set;
        }
    }
}