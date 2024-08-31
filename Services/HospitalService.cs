
using HospitalManagment.Models;

public class HospitalService
{
    private readonly ApplicationDbContext _context;

    public HospitalService(ApplicationDbContext context)
    {
        _context = context;
    }

    public Hospital CreateHospital(string hospitalName, string adminEmail)
    {
        var hospital = new Hospital
        {
            Name = hospitalName,
            HospitalCode = GenerateRandomCode(8),
            Admin = new Admin
            {
                Username = GenerateRandomUsername(10),
                PasswordHash = HashPassword(GenerateRandomPassword(12)),
                Email = adminEmail
            }
        };

        _context.Hospitals.Add(hospital);
        _context.SaveChanges(); // Save the hospital and admin to the database

        return hospital;
    }

    private string GenerateRandomCode(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return GenerateRandomString(chars, length);
    }

    private string GenerateRandomUsername(int length)
    {
        const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        return GenerateRandomString(chars, length);
    }

    private string GenerateRandomPassword(int length)
    {
        const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()";
        return GenerateRandomString(chars, length);
    }

    private string GenerateRandomString(string characters, int length)
    {
        var random = new Random();
        var result = new System.Text.StringBuilder(length);
        for (int i = 0; i < length; i++)
        {
            result.Append(characters[random.Next(characters.Length)]);
        }
        return result.ToString();
    }

    private string HashPassword(string password)
    {
        return BCrypt.Net.BCrypt.HashPassword(password);
    }
}
