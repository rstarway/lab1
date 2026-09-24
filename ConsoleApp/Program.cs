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

    if (s == "0")
        break;

    switch (s)
    {
        case "1":
            Console.Write("ФИО: ");
            string name = Console.ReadLine();
            Console.Write("Возраст: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Дата (дд.мм.гггг): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Причина смерти: ");
            string cause = Console.ReadLine();
            Console.Write("Камера (1-" + logic.cells + "): ");
            int cell = int.Parse(Console.ReadLine());
            if (logic.Add(name, age, date, cause, cell))
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
            int id = int.Parse(Console.ReadLine());
            Console.Write("ФИО: ");
            string name2 = Console.ReadLine();
            Console.Write("Возраст: ");
            int age2 = int.Parse(Console.ReadLine());
            Console.Write("Дата (дд.мм.гггг): ");
            DateTime date2 = DateTime.Parse(Console.ReadLine());
            Console.Write("Причина смерти: ");
            string cause2 = Console.ReadLine();
            Console.Write("Камера: ");
            int cell2 = int.Parse(Console.ReadLine());
            if (logic.Edit(id, name2, age2, date2, cause2, cell2))
                Console.WriteLine("Изменено");
            else
                Console.WriteLine("Не получилось");
            break;

        case "4":
            Console.Write("id: ");
            int id2 = int.Parse(Console.ReadLine());
            if (logic.Delete(id2))
                Console.WriteLine("Удалено");
            else
                Console.WriteLine("Нет такой записи");
            break;

        case "5":
            Console.Write("Причина: ");
            string str = Console.ReadLine();
            List<Record> res = logic.FindByCause(str);
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
