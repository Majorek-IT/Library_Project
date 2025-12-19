using System;

public class USER
{
    [Key]
    public int USER_ID { get; set; }

    [Required]
    public string FIRST_NAME { get; set; }

    [Required]
    public string LAST_NAME { get; set; }

    [Required, EmailAddress]
    public string EMAIL { get; set; }

    public ICollection<Loan> Loans { get; set; }
    public USER()
	{
	}
}
