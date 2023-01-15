namespace UsersManagement.Model.Notes.Queries.GetUsersAllNotes;

public class GetUsersAllNotesOutput
{
    public string Content { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }
    public int Views { get; set; }
    public bool Published { get; set; }
    public int UserId { get; set; }
}
