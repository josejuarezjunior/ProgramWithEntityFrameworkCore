﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyReaderBook.Domain
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublicationDate { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
