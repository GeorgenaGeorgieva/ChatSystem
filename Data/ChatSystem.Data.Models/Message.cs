using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ChatSystem.Data.Models
{
    public class Message
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string SenderUserName { get; set; }

        public DateTime CreatedOn { get; set; }

        [Required]
        public string Content { get; set; }
        public string Reciever { get; set; }

        public User User { get; set; }
        public string UserId { get; set; }
    }
}
