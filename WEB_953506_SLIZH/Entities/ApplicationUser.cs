using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System.Text;

namespace WEB_953506_SLIZH.Entities
{
    public class ApplicationUser: IdentityUser
    {
        public byte[] AvatarImage { get; set; }
    }
}
