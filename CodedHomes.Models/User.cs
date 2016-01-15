﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodedHomes.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }

        /// <summary>
        /// EF relationship
        /// </summary>
        public ICollection<Role> Roles { get; set; }

        public User()
        {
            this.Roles = new List<Role>();
        }
    }
}
