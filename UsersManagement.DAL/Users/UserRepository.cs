using UsersManagement.DAL.DbContexts;
using UsersManagement.Model.Users;

namespace UsersManagement.DAL.Users;

public class UserRepository : IUserRepository
{
    private readonly UserDbContext _userDbContext;

    public UserRepository(UserDbContext userDbContext)
    {
        _userDbContext = userDbContext;
    }

    public IEnumerable<User> GetAllUsers()
    {
        IQueryable<User> users = _userDbContext.Users;
        return users.ToList();
    }

    public User GetUserById(int id)
    {
        User user = _userDbContext.Users.FirstOrDefault(u => u.Id == id);
        return user;
    }

    public void AddUser(User user)
    {
        _userDbContext.AddAsync(user);
        _userDbContext.SaveChangesAsync();
    }

    public void UpdateUser(User user)
    {
        _userDbContext.Update(user);
        _userDbContext.SaveChangesAsync();
    }

    public void DeleteUser(int id)
    {
        _userDbContext.Remove(id);
        _userDbContext.SaveChangesAsync();
    }
}
