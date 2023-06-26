using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace EBikeRental_Web_App_System.Areas.Identity.Data;

// Add profile data for application users by adding properties to the EBikeRental_Web_App_SystemUser class
public class EBikeRental_Web_App_SystemUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

