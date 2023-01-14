using UsersManagement.Model.Users.Entities;

namespace UsersManagement.DAL.Users;

public interface IUserRepository
{
    IEnumerable<User> GetAllUsers();
    User GetUserById(int id);
    void AddUser(User user);
    void UpdateUser(User user);
    void DeleteUser(int id);
}
