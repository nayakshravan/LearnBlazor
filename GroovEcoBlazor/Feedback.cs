using System.ComponentModel.DataAnnotations;

public class Feedback
{
	[Required(ErrorMessage = "Name is required.")]
    public string Name { get; set; }

    [EmailAddress(ErrorMessage = "Invalid email address.")]
    public string Email { get; set; }

    [StringLength(500, ErrorMessage = "Comment cannot exceed 500 characters.")]
    public string Comment { get; set; }
}
