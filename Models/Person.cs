﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTask2.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}