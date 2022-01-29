﻿using Microsoft.AspNetCore.Identity;

namespace KariyerNet.Domain.Entities.Authentications
{
    public class User : IdentityUser<int>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

    }
}
