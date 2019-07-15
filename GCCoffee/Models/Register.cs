using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using System.ComponentModel.DataAnnotations;

namespace GCCoffee.Models
{
    public class Register
    {
		public string UserName { get; set; }

		[EmailAddress]
		public string Email { get; set; }

        [Password]
		public string Password { get; set; }
	}
}
