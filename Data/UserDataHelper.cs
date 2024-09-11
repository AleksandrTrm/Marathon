using System.IO;
using System.Collections.Generic;
using System.Text.Json;

public class User
{
    public string Email { get; set; }

    public string Password { get; set; }

    public string Role { get; set; }

    public string MarathonInfo { get; set; }
}

public class Users
{
    public HashSet<User> User { get; set; }
}

public class UserDataHelper
{
    private string _jsonFilePath = @"H:\Учебная практика\Maraphone1\Maraphone\Data\Users.json";
    private Users _users;

    public bool RecordUser(Users users)
    {
        try
        {
            string json = JsonSerializer.Serialize(users);
            File.WriteAllText(_jsonFilePath, json);

            return true;
        }
        catch { return false; }
    }

    public Users GetUsers()
    {
        try
        {
            string jsonString = File.ReadAllText(_jsonFilePath);
            _users = JsonSerializer.Deserialize<Users>(jsonString);
        }
        catch { }

        return _users;
    }
}