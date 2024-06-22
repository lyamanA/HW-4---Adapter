using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4___Adapter
{
    public class PlSqlDatabase
    {
        private Dictionary<int, User> _users; 
        private int _nextUserId = 500;

        public PlSqlDatabase()
        {
            _users = new Dictionary<int, User>();
        }
        public void PushUser(User user)
        {
            user.Id = _nextUserId++; 
            _users.Add(user.Id, user);
        }
        public User GetUser(int id)
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
        public void Modify(object user)
        {
            if (!(user is User))
            {
                Console.WriteLine("Invalid user type. Expected User.");
                return;
            }

            var typedUser = (User)user;

            if (_users.ContainsKey(typedUser.Id))
            {
                // В PL/SQL обычно используется процедура или функция для модификации данных
                Console.WriteLine($"Executing PL/SQL procedure to modify user with ID {typedUser.Id}");
                _users[typedUser.Id] = typedUser; // Обновляем пользователя в коллекции
            }
            else
            {
                Console.WriteLine("User not found");
            }
        }

    }
}
