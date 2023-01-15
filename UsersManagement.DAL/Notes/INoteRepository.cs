using UsersManagement.Model.Notes.Entities;

namespace UsersManagement.DAL.Notes;

public interface INoteRepository
{
    IEnumerable<Note> GetAllUserNotes(int userId);
    Note GetNoteById(int id);
    void AddNote(Note note);
    void UpdateNote(Note note);
    void DeleteNote(int id);
}
