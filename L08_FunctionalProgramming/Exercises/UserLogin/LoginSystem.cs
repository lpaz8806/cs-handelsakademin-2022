namespace L08_FunctionalProgramming.Exercises.UserLogin;

public class LoginSystem
{
    private List<User> _users = new();

    public LoginSystem(params User[] users)
    {
        _users.AddRange(users);
    }

    public User? Login(string name, string password)
    {
        return null;
    }
}