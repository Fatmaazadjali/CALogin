﻿using System.ComponentModel.DataAnnotations;

namespace CodeAcademy.ViewModel
{
    public class LoginVM
    {
		[EmailAddress]
		public string Email { get; set; }
		[DataType(DataType.Password)]
		public string Password { get; set; }
		public bool RememberMe { get; set; }
	}
}
