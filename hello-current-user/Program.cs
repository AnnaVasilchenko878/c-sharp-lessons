Console.Write("Введите имя пользователя: ");
string user = Console.ReadLine();
if (user.ToLower() == "jane") {
  Console.WriteLine("Ура это же Jane!");
} else {
  Console.Write("Привет, " + user);
}