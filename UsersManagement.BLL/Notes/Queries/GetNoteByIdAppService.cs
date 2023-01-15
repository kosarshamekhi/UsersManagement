using MediatR;
using UsersManagement.DAL.Notes;
using UsersManagement.Model.Framework;
using UsersManagement.Model.Notes.Queries.GetNoteById;

namespace UsersManagement.BLL.Notes.Queries;

public class GetNoteByIdAppService : IRequestHandler<GetNoteByIdInput, ApplicationServiceResponse<GetNoteByIdOutput>>
{
    private readonly INoteRepository _noteRepository;

    public GetNoteByIdAppService(INoteRepository noteRepository)
    {
        _noteRepository = noteRepository;
    }
    public async Task<ApplicationServiceResponse<GetNoteByIdOutput>> Handle(GetNoteByIdInput getNoteByIdInput, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
