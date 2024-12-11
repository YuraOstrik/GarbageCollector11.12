namespace GarbageCollectore11._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Poem poem = new Poem("Ромео и Джульетта", "Уильям Шекспир", "Трагедия", 1597);
            //Console.WriteLine(poem.ToString());
            //poem = null;
            //GC.Collect();
            //GC.WaitForPendingFinalizers();


            using (Store store = new Store("Универсам", "ул. Центральная, 10", TypeM.Food))
            {
                store.Show();
            }
            Store store1 = new Store("Универсам", "ул. Центральная, 10", TypeM.Food);
            store1.Show();
            store1.Dispose();
        }
    }
    class Poem : IDisposable
    {
        public string Fio { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Genre {  get; set; }

        public Poem(string name,string fio, string genre ,int year)
        {
            Fio = fio;
            Name = name;
            Year = year;
            Genre = genre;
        }
        public override string ToString()
        {
            return $"Название - {Name} / Автор - {Fio} / Жанр - {Genre} / Год - {Year}";
        }
        public void Dispose()
        {
            Console.WriteLine($"{Name} - закрыт");
        }
        ~Poem() 
        {
            Console.WriteLine("Desc");
        }

    }
    public enum TypeM {
        Food,
        Economic,
        Cloth,
        Shoes
    }

    class Store : IDisposable
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public TypeM Tip { get; set; }
        public Store(string name, string ad, TypeM tip)
        {
            Name = name;
            Adress = ad;
            Tip = tip;
        }
        public void Show()
        {
            Console.WriteLine($"{Name} / {Adress} / {Tip}");
        }
        public void Dispose()
        {
            Console.WriteLine($"{Name} - закрыт");
        }
        ~Store()
        {
            Console.WriteLine("Desc");
        }
    }

}
