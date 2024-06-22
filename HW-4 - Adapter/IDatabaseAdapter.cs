using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4___Adapter
{
    public interface IDatabaseAdapter
    {
        void InsertUser(User user);
        User FetchUser(int id);
        bool DeleteUser(int id);
        void Modify(User user);
    }
}
