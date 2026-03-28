namespace DesignPatterns.BusinessLogicObjects.Users;

public class User
{
    private string _login { get; set; }

    public string Login 
    { 
        get => _login;
        set
        {
            if (string.IsNullOrWhiteSpace(_login))
            {
                throw new AggregateException("The login cannot be empty");
            }
            _login = value;
        }
    }

    public int Age { get; private set; }

    public User(int age)
    {
        Age = age;
    }
}
