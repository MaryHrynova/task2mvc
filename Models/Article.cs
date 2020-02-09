using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTask2.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public string Header { get; set; }
    }
}