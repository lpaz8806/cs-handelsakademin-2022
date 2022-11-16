namespace L08_FunctionalProgramming.Exercises.UserLogin;

public class LoginSystem
{
    private List<User> _users = new();

    public LoginSystem(params User[] users)
    {
        _users.AddRange(users);
    }

    public void Login(string name, string password)
    {
    }
}