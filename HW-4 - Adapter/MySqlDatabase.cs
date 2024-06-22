using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4___Adapter
{
    public class MySqlDatabase
    {
        private Dictionary<int, User> _users;
        private int _nextUserId = 1000;

        public MySqlDatabase()
        {
            _users = new Dictionary<int, User>();
        }
        public void InsertUser(User user)
        {
            user.Id = _nextUserId++;
            _users.Add(user.Id, user);
        }
        public User GetUserById(int id)
        {
            if (_users.ContainsKey(id))
            {
                return _users[id]; 
            }
            else
            {
                return null; 
            }

        }
        public bool RemoveUser(int id)
        {
            return _users.Remove(id);
        }
        public void Update(User user)
        {
            if (_users.ContainsKey(user.Id))
            {
                _users[user.Id] = user; 
            }
            else
            {
                Console.WriteLine("User not found");
            }
        }

    }
}
