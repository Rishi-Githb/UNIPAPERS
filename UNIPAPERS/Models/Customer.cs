﻿using Microsoft.AspNetCore.Identity;

namespace UNIPapers.Models
{
    public class Customer : IdentityUser
    {
        public string? Name { get; set; }
        public string? address { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
    }

}