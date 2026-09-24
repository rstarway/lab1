using Model;

Logic logic = new Logic();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("1 - добавить");
    Console.WriteLine("2 - показать все");
    Console.WriteLine("3 - изменить");
    Console.WriteLine("4 - удалить");
    Console.WriteLine("5 - поиск по причине");
    Console.WriteLine("6 - камеры");
    Console.WriteLine("0 - выход");
    Console.Write("> ");
    string s = Console.ReadLine();

    if (s == null || s == "0")
        break;

    switch (s.Trim())
    {
        case "1":
            Console.Write("ФИО: ");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("ФИО не может быть пустым");
                break;
            }
            Console.Write("Возраст: ");
            int age;
            if (!int.TryParse(Console.ReadLine(), out age) || age < 0 || age > 120)
            {
                Console.WriteLine("Возраст должен быть числом от 0 до 120");
                break;
            }
            Console.Write("Дата (дд.мм.гггг): ");
            DateTime date;
            if (!DateTime.TryParse(Console.ReadLine(), out date))
            {
                Console.WriteLine("Неправильная дата");
                break;
            }
            Console.Write("Причина смерти: ");
            string cause = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(cause))
            {
                Console.WriteLine("Причина не может быть пустой");
                break;
            }
            Console.Write("Камера (1-" + logic.cells + "): ");
            int cell;
            if (!int.TryParse(Console.ReadLine(), out cell))
            {
                Console.WriteLine("Камера должна быть числом");
                break;
            }
            if (logic.Add(name.Trim(), age, date, cause.Trim(), cell))
                Console.WriteLine("Добавлено");
            else
                Console.WriteLine("Камера занята или нет такой");
            break;

        case "2":
            List<Record> all = logic.GetAll();
            if (all.Count == 0)
                Console.WriteLine("Пусто");
            foreach (Record r in all)
                Console.WriteLine(r.Id + " | " + r.Name + " | " + r.Age + " | " + r.Date.ToShortDateString() + " | " + r.Cause + " | камера " + r.Cell);
            break;

        case "3":
            Console.Write("id: ");
            int id;
            if (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("id должен быть числом");
                break;
            }
            Console.Write("ФИО: ");
            string name2 = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name2))
            {
                Console.WriteLine("ФИО не может быть пустым");
                break;
            }
            Console.Write("Возраст: ");
            int age2;
            if (!int.TryParse(Console.ReadLine(), out age2) || age2 < 0 || age2 > 120)
            {
                Console.WriteLine("Возраст должен быть числом от 0 до 120");
                break;
            }
            Console.Write("Дата (дд.мм.гггг): ");
            DateTime date2;
            if (!DateTime.TryParse(Console.ReadLine(), out date2))
            {
                Console.WriteLine("Неправильная дата");
                break;
            }
            Console.Write("Причина смерти: ");
            string cause2 = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(cause2))
            {
                Console.WriteLine("Причина не может быть пустой");
                break;
            }
            Console.Write("Камера: ");
            int cell2;
            if (!int.TryParse(Console.ReadLine(), out cell2))
            {
                Console.WriteLine("Камера должна быть числом");
                break;
            }
            if (logic.Edit(id, name2.Trim(), age2, date2, cause2.Trim(), cell2))
                Console.WriteLine("Изменено");
            else
                Console.WriteLine("Не получилось");
            break;

        case "4":
            Console.Write("id: ");
            int id2;
            if (!int.TryParse(Console.ReadLine(), out id2))
            {
                Console.WriteLine("id должен быть числом");
                break;
            }
            if (logic.Delete(id2))
                Console.WriteLine("Удалено");
            else
                Console.WriteLine("Нет такой записи");
            break;

        case "5":
            Console.Write("Причина: ");
            string str = Console.ReadLine();
            if (str == null)
                str = "";
            List<Record> res = logic.FindByCause(str.Trim());
            if (res.Count == 0)
                Console.WriteLine("Ничего не найдено");
            foreach (Record r in res)
                Console.WriteLine(r.Id + " | " + r.Name + " | " + r.Age + " | " + r.Date.ToShortDateString() + " | " + r.Cause + " | камера " + r.Cell);
            break;

        case "6":
            List<int> busy = logic.BusyCells();
            List<int> free = logic.FreeCells();
            Console.WriteLine("Занято: " + busy.Count + " (" + string.Join(", ", busy) + ")");
            Console.WriteLine("Свободно: " + free.Count + " (" + string.Join(", ", free) + ")");
            break;

        default:
            Console.WriteLine("Нет такого пункта");
            break;
    }
}
