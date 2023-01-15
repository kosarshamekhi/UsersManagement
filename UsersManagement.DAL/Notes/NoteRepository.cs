using UsersManagement.DAL.DbContexts;
using UsersManagement.Model.Notes.Entities;

namespace UsersManagement.DAL.Notes;

public class NoteRepository : INoteRepository
{
    private readonly UserDbContext _userDbContext;

    public NoteRepository(UserDbContext userDbContext)
    {
        _userDbContext = userDbContext;
    }
    public IEnumerable<Note> GetAllUserNotes(int userId)
    {
        var notes = _userDbContext.Notes.Where(x => x.UserId == userId).ToList();
        return (IEnumerable<Note>)notes;
    }

    public Note GetNoteById(int id)
    {
        Note note = _userDbContext.Notes.FirstOrDefault(u => u.Id == id);
        return note;
    }

    public void AddNote(Note note)
    {
        _userDbContext.AddAsync(note);
        _userDbContext.SaveChangesAsync();
    }

    public void UpdateNote(Note note)
    {
        _userDbContext.Update(note);
        _userDbContext.SaveChangesAsync();
    }

    public void DeleteNote(int id)
    {
        _userDbContext.Remove(id);
        _userDbContext.SaveChangesAsync();
    }
}
