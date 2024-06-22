using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4___Adapter
{
    public class MsSqlAdapter : IDatabaseAdapter
    {
        private readonly MsSqlDatabase _msSqlDatabase;

        public MsSqlAdapter(MsSqlDatabase msSqlDatabase)
        {
            _msSqlDatabase = msSqlDatabase;
        }

        public void InsertUser(User user)
        {
            _msSqlDatabase.InsertUser(user);
        }

        public User FetchUser(int id)
        {
            return _msSqlDatabase.FetchUser(id);
        }

        public bool DeleteUser(int id)
        {
            return _msSqlDatabase.DeleteUser(id);
        }

        public void Modify(User user)
        {
            _msSqlDatabase.Modify(user);
        }
    }
}
