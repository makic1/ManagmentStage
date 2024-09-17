using Microsoft.EntityFrameworkCore;

namespace StageManagment.Service
{
    public class ServiceAccount
    {
        private readonly DbContextStageManagment _context;

        public ServiceAccount(DbContextStageManagment context)
        {
            _context = context;
        }

        /// <summary>
        /// Find the account with username
        /// </summary>
        /// <param name="username"></param>
        /// <returns>One Account with the searched username</returns>
        public Entities.Account FindAccount(string username)
        {
            return _context.Accounts.AsNoTracking().FirstOrDefault(a => a.Username == username);
        }
    }
}
