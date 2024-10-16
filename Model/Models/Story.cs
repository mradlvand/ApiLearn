using Model.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Model.Models
{
    public class Story
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public Category CategoryId { get; set; }
        public string? Description { get; set; } 
        public DateTime? CreationDateTime { get; set; }
        public string? Image { get; set; }
        public string? Video { get; set; }
        public bool Status { get; set; }
        public User User { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }
    }
}
