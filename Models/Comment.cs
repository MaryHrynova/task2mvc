using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTask2.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public virtual Person Person { get; set; }
    }
}