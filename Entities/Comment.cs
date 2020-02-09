using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public virtual Person Person { get; set; }
    }
}