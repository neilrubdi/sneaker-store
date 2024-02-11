﻿using Microsoft.AspNetCore.Identity;

namespace sneaker_store.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set;}
        public string LastName { get; set;}

    }
}
