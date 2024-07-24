using System.ComponentModel.DataAnnotations;

namespace BTLWebNC_QLLopHocOnline.Models;

public class LoginFormCredentialModel {
	[Display(Name = "Tên tài khoản")]
	public required string Username { get; set; }

	[Display(Name = "Mật khẩu")]
	public required string Password { get; set; }
}