using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4___Adapter
{
    public class PlSqlAdapter : IDatabaseAdapter
    {
        private readonly PlSqlDatabase _plSqlDatabase;

        public PlSqlAdapter(PlSqlDatabase plSqlDatabase)
        {
            _plSqlDatabase = plSqlDatabase;
        }

        public void InsertUser(User user)
        {
            _plSqlDatabase.PushUser(user);
        }

        public User FetchUser(int id)
        {
            return _plSqlDatabase.GetUser(id);
        }

        public bool DeleteUser(int id)
        {
            return _plSqlDatabase.RemoveUser(id);
        }

        public void Modify(User user)
        {
            _plSqlDatabase.Modify(user); 
        }
    }
}
