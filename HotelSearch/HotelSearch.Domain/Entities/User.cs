﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSearch.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime Registration { get; set; }
        public bool Situation { get; set; }
    }
}
