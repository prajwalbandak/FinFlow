public partial struct UserProfile
{
    public string FirstName { get; set;}
    public string LastName { get; set;}

    public int age { get; set;}
    public string Email { get; set;}


    public UserProfile(string firstName, string lastName, int age, string Email)
    {
        if (string.IsNullOrWhiteSpace(firstName))
            throw new ArgumentException("FirstName cannot be empty");

        if (string.IsNullOrWhiteSpace(lastName))
            throw new ArgumentException("LastName cannot be empty");

        if (age <= 0)
            throw new ArgumentException("Age must be positive");

        if (!email.Contains("@"))
            throw new ArgumentException("Email is invalid");

        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Email = email;
    }
     public override string ToString() => $"{FirstName} {LastName}, {Age} ({Email})";


       public UserProfile WithEmail(UserEmail newEmail)
    {
        return new UserProfile(FirstName, LastName, Age, newEmail);
    }
}