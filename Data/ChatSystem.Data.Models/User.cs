using Microsoft.AspNetCore.Identity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChatSystem.Data.Models
{
    public class User : IdentityUser
    {
        public User()
        {
            this.Messages = new List<Message>();
        }

        public bool IsOnline { get; set; }

        public ICollection<Message> Messages { get; set; }
    }
}
