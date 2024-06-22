using HW_4___Adapter;

var msSqlDatabase = new MsSqlDatabase();
var mySqlDatabase = new MySqlDatabase();
var plSqlDatabase = new PlSqlDatabase();

var msSqlAdapter = new MsSqlAdapter(msSqlDatabase);
var mySqlAdapter = new MySqlAdapter(mySqlDatabase);
var plSqlAdapter = new PlSqlAdapter(plSqlDatabase);

var userManagerMsSql = new UserManager(msSqlAdapter);
ManageUsers(userManagerMsSql);

var userManagerMySql = new UserManager(mySqlAdapter);
ManageUsers(userManagerMySql);

var userManagerPlSql = new UserManager(plSqlAdapter);
ManageUsers(userManagerPlSql);

void ManageUsers(UserManager userManager)
{
    var user = new User(643,"Mary", "MaryJGoff@jourrapide.com");
    userManager.CreateUser(user);

    // Получение пользователя по ID
    var fetchedUser = userManager.GetUser(user.Id);
    Console.WriteLine($"Fetched User: {fetchedUser?.Name} with Email: {fetchedUser?.Email}");

    // Обновление пользователя
    user.Name = "Linda";
    user.Email = "LindaSFreund@jourrapide.com";
    userManager.UpdateUser(user);

    // Получение обновленного пользователя
    var updatedUser = userManager.GetUser(user.Id);
    Console.WriteLine($"Updated User: {updatedUser?.Name} with Email: {updatedUser?.Email}");

    // Удаление пользователя
    var deleteResult = userManager.RemoveUser(user.Id);
    Console.WriteLine($"User deleted: {deleteResult}");
}