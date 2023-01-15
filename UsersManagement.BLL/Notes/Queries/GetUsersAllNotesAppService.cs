using MediatR;
using UsersManagement.DAL.Notes;
using UsersManagement.Model.Framework;
using UsersManagement.Model.Notes.Queries.GetUsersAllNotes;

namespace UsersManagement.BLL.Notes.Queries;

public class GetUsersAllNotesAppService : IRequestHandler<GetUsersAllNotesInput, ApplicationServiceResponse<GetUsersAllNotesOutput>>
{
    private readonly INoteRepository _noteRepository;

    public GetUsersAllNotesAppService(INoteRepository noteRepository)
    {
        _noteRepository = noteRepository;
    }
    public async Task<ApplicationServiceResponse<GetUsersAllNotesOutput>> Handle(GetUsersAllNotesInput getUsersAllNotesInput, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
