﻿using Microsoft.AspNetCore.Identity;

namespace RealEstate.API.Model
{
    public class UserModel : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

    }
}
