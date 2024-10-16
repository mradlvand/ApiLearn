using Model.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Model.Models
{
    public class UserTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Category CategoryId { get; set; }
        public DateTime? CreationDateTime { get; set; }
        public string? Image { get; set; }
        public string? Picture { get; set; }
        public bool Status { get; set; }
    }
}
