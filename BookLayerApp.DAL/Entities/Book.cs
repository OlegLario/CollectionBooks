﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLayerApp.DAL.Entities
{
    public class Book
    {
        public int? Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public DateTime EditionDate { get; set; }
    }
}
