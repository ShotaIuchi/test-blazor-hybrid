using Microsoft.EntityFrameworkCore;
using TestRestAPI.Repository;
using TestShared.Model;

namespace TestRestAPI.Service
{
    public class TutorialService(TutorialRepository repository)
    {
        public async Task<List<Users>> GetAllUsersAsync()
        {
            return await repository.Users.ToListAsync();
        }

        public async Task<List<Users>> GetAllUsersRelationAsync()
        {
            return await repository.Users
                .Include(u => u.Base)
                .Include(u => u.Status)
                .ToListAsync();
        }

        public async Task AddUserAsync(Users user)
        {
            repository.Users.Add(user);
            await repository.SaveChangesAsync();
        }

    }

}
