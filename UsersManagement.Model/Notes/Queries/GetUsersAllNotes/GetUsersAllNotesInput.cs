using MediatR;
using UsersManagement.Model.Framework;

namespace UsersManagement.Model.Notes.Queries.GetUsersAllNotes;

public class GetUsersAllNotesInput : IRequest<ApplicationServiceResponse<GetUsersAllNotesOutput>>
{
}
