using EMS.Data;
using System.Linq;

namespace EMS.Repository
{
    public class UserRepository
    {
        private EMSContext _db;
        public UserRepository()
        {
            _db = new EMSContext();
        }

        public bool isValidPassword(string username , string password)
        {
            return _db.Users.Any(a => a.Username == username && a.Password == password);
        }
    }
}
