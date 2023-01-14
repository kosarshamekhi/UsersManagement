using UsersManagement.Model.Notes.Entities;

namespace UsersManagement.Model.Users.Queries.GetUsersById;

public class GetUserByIdOutput
{
    public string UserId { get; set; }
    public string UserName { get; set; }
    public string UserEmail { get; set; }
    public int UserAge { get; set; }
    public ICollection<Note> Notes { get; set; }
}
