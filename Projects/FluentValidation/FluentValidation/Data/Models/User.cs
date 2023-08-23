class User
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
}

// Db должен быть удаленным для того чтобы я быстро подклчился
// Bcrypt, Cookies, UserClaims, What is JWT ? 