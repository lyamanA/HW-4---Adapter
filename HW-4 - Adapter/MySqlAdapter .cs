using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4___Adapter
{
    public class MySqlAdapter : IDatabaseAdapter
    {
        private readonly MySqlDatabase _mySqlDatabase;

        public MySqlAdapter(MySqlDatabase mySqlDatabase)
        {
            _mySqlDatabase = mySqlDatabase;
        }

        public void InsertUser(User user)
        {
            _mySqlDatabase.InsertUser(user);
        }

        public User FetchUser(int id)
        {
            return _mySqlDatabase.GetUserById(id);
        }

        public bool DeleteUser(int id)
        {
            return _mySqlDatabase.RemoveUser(id);
        }

        public void Modify(User user)
        {
            _mySqlDatabase.Update(user);
        }
    }
}
