using SubtypeCovariance;

namespace SubtypeCovariance
{
    class Program
    {
        static void Main(string[] args)
        {
            IEntityRepository<User> userRepository = new UserRepository();

            User newUser = new User();
            userRepository.Add(newUser);

            User user = userRepository.GetByID(newUser.ID);
            user.EmailAddress = "example@example.com";
            user.DateOfBirth = new DateTime(1990, 1, 1);

            Console.WriteLine($"User  ID: {user.ID}, Email: {user.EmailAddress}, Date of Birth: {user.DateOfBirth.ToShortDateString()}");
        }
    }
}