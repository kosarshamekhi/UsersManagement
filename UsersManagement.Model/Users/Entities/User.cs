using UsersManagement.Model.Notes.Entities;

namespace UsersManagement.Model.Users.Entities;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
    public string Website { get; set; }
    public ICollection<Note> Notes { get; set; }
}
