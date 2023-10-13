namespace anket_2;

public class User
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public DateTime birthdate { get; set; }

    public User (string name, string surname, string email, string phone, DateTime birthdate)
    {
        Name = name;
        Surname = surname;
        Email = email;
        Phone = phone;
        this.birthdate = birthdate;
    }

    public override string ToString()
    {
        return $"{this.Email}";
    }
}