using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4___Adapter
{
    public class MsSqlDatabase 
    {
        private Dictionary<int, User> _users; // для хранения пользователей
        private int _nextUserId = 1; // для генерации новых ID 

        public MsSqlDatabase()
        {
            _users = new Dictionary<int, User>();
        }
        public void InsertUser(User user)
        {
            user.Id = _nextUserId++; // ID для нового пользователя
            _users.Add(user.Id, user); // пользователя в коллекцию
        }

        public User FetchUser(int id)
        {
            if (_users.ContainsKey(id))
            {
                return _users[id]; // Возвращаем пользователя по ID
            }
            else
            {
                return null; // если пользователь не найден
            }
        }
        public bool DeleteUser(int id)
        {
            return _users.Remove(id);
        }
        public void Modify(User user)
        {
            if (_users.ContainsKey(user.Id))
            {
                _users[user.Id] = user; // Обновление пользователя в коллекции
            }
            else
            {
                Console.WriteLine("User not found");
            }
        }

    }
}
