using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4___Adapter
{
    public class UserManager
    {
        private readonly IDatabaseAdapter _database;

        public UserManager(IDatabaseAdapter database)
        {
            _database = database;
        }

        public void CreateUser(User user)
        {
            _database.InsertUser(user);
        }

        public User GetUser(int id)
        {
            return _database.FetchUser(id);
        }

        public bool RemoveUser(int id)
        {
            return _database.DeleteUser(id);
        }

        public void UpdateUser(User user)
        {
            _database.Modify(user);
        }
    }
}
