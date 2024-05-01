using System.Text;

namespace InteractiveMapProject.API.Utilities;

public static class RandomPasswordGenerator
{
    private const int passwordLength = 12;
    private const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()-_=+";

    public static string GenerateRandomPassword(int length = passwordLength)
    {
        StringBuilder password = new StringBuilder();
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            int index = random.Next(validChars.Length);
            password.Append(validChars[index]);
        }

        return password.ToString();
    }
}
