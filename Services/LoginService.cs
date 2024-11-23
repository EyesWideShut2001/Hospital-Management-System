using HospitalManagment.Models;

namespace Hospital_Managment.Services;

public class LoginService
{
    private readonly ApplicationDbContext _context;

    public LoginService(ApplicationDbContext context)
    {
        _context = context;
    }

    public Admin LoginCheck(string username, string password)
    {
        var adminList = _context.Admins.Where(e => e.Username == username).ToList();
        if (adminList.Count == 0)
        {
            throw new Exception("Username does not exist.");
        }

        if (adminList.Count != 1)
        {
            throw new Exception("Duplicate Username.");
        }
        var dbAdmin = adminList[0];
        var isCorrectPassword = BCrypt.Net.BCrypt.Verify(password, dbAdmin.PasswordHash);
        if (isCorrectPassword)
        {
            return dbAdmin;
        }
        throw new Exception("Invalid password.");
    }
}