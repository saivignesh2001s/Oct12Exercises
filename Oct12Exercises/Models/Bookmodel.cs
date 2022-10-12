using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Oct12Exercises.Models
{
    public class Bookmodel
    {
        [Required()]
        public int BookId
        {
            get;
            set;
        }
        [MaxLength(40,ErrorMessage ="Characters are more than 40")]
        public string Bookname
        {
            get;
            set;
        }
        [MaxLength(30, ErrorMessage = "Characters are more than 30")]
        public string Author
        {
            get;
            set;
        }

        public int? Cost
        {
            get;
            set;
        }
      
        [MaxLength(30, ErrorMessage = "Characters are more than 30")]
        public string category
        {
            get;
            set;
        } 
    }
}