namespace L08_FunctionalProgramming.Exercises.UserLogin;

public static class LoginApp
{
    public static void Run()
    {
        var auth = InitLoginSystem();
        List<User> usersLoggedIn = new List<User>();
        List<User> bannedUsers = new List<User>();

        while (true)
        {
            Console.Write("username: ");
            var username = Console.ReadLine();
            Console.Write("password: ");
            var password = Console.ReadLine();

            auth.Login(username, password);
        }
    }

    static LoginSystem InitLoginSystem()
    {
        var auth = new LoginSystem();
        return auth;
    }
}