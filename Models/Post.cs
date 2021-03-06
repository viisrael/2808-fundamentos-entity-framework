using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models{

    // [Id] INT NOT NULL IDENTITY(1, 1),
    // [CategoryId] INT NOT NULL,
    // [AuthorId] INT NOT NULL,
    // [Title] VARCHAR(160) NOT NULL,
    // [Summary] VARCHAR(255) NOT NULL,
    // [Body] TEXT NOT NULL,
    // [Slug] VARCHAR(80) NOT NULL,
    // [CreateDate] DATETIME NOT NULL DEFAULT(GETDATE()),
    // [LastUpdateDate] DATETIME NOT NULL DEFAULT(GETDATE()),

    public class Post{

        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Summary { get; set; } = "";
        public string Body { get; set; } = "";
        public string Slug { get; set; } = "";
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        
        public Category Category { get; set; }
        public User Author { get; set; }

        public List<Tag> Tags { get; set; }
    }
}