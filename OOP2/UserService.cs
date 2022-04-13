namespace OOP2
{
    public class UserService : IUserService
    {
        public string Hello(string message, string UserName) 
        {
            return $"{message}, {UserName}!";
        }

        public User PsyhAge(User user)
        {
            Random random = new Random();
            int numb = random.Next(1, 60);
            user.Age += numb + 10;
            return user;
        }
    }
}
