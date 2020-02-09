using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Entities
{
    public class Article
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public string Header { get; set; }
    }
}