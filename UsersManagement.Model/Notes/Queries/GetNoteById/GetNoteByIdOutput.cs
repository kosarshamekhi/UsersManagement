namespace UsersManagement.Model.Notes.Queries.GetNoteById;

public class GetNoteByIdOutput
{
    public string Content { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }
    public int Views { get; set; }
    public bool Published { get; set; }
    public int UserId { get; set; }
}
