using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Oct12Exercises.Models
{
    public class membermodel
    {
        [Required()]
        public int memberId { get; set; }
        [MaxLength(40,ErrorMessage ="Can't be more than 40")]
        public string memberName { get; set; }
        public DateTime Accountopen
        {
            get;
            set;
        }
        public int? maxbooksallowed
        {
            get;
            set;
        }
        public int? penaltyamount
        {
            get;
            set;
        }
    }
}