namespace Model
{
    public class Logic
    {
        List<Record> list = new List<Record>();
        int next = 1;
        public int cells = 10;

        public bool Add(string name, int age, DateTime date, string cause, int cell)
        {
            if (cell < 1 || cell > cells)
                return false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Cell == cell)
                    return false;
            }

            Record r = new Record();
            r.Id = next;
            r.Name = name;
            r.Age = age;
            r.Date = date;
            r.Cause = cause;
            r.Cell = cell;
            list.Add(r);
            next++;
            return true;
        }

        public List<Record> GetAll()
        {
            return list;
        }

        public bool Edit(int id, string name, int age, DateTime date, string cause, int cell)
        {
            if (cell < 1 || cell > cells)
                return false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Cell == cell && list[i].Id != id)
                    return false;
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Id == id)
                {
                    list[i].Name = name;
                    list[i].Age = age;
                    list[i].Date = date;
                    list[i].Cause = cause;
                    list[i].Cell = cell;
                    return true;
                }
            }
            return false;
        }

        public bool Delete(int id)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Id == id)
                {
                    list.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public List<Record> FindByCause(string cause)
        {
            List<Record> res = new List<Record>();
            foreach (Record r in list)
            {
                if (r.Cause.ToLower().Contains(cause.ToLower()))
                    res.Add(r);
            }
            return res;
        }

        public List<int> BusyCells()
        {
            List<int> res = new List<int>();
            foreach (Record r in list)
                res.Add(r.Cell);
            res.Sort();
            return res;
        }

        public List<int> FreeCells()
        {
            List<int> res = new List<int>();
            for (int i = 1; i <= cells; i++)
            {
                bool busy = false;
                foreach (Record r in list)
                {
                    if (r.Cell == i)
                        busy = true;
                }
                if (!busy)
                    res.Add(i);
            }
            return res;
        }
    }
}
