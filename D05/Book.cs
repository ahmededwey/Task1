namespace D05
{
    class Book
    {
        //Make Defualt Constructor, Parametariezed Constructor, Copy Constructor
        public Book()
        {
            Id = 0;
            AutherName = string.Empty;
            Name = string.Empty;
            Edition = 0;
            Category = string.Empty;
        }
        public Book(int id, string autherName, string name, int edition, string category)
        {
            Id = id;
            AutherName = autherName;
            Name = name;
            Edition = edition;
            Category = category;
        }
        public Book(Book book)
        {
            Id = book.Id;
            AutherName = book.AutherName;
            Name = book.Name;
            Edition = book.Edition;
            Category = book.Category;
        }



        public int Id { get; set; }= 0;
        public string AutherName { get; set; }
        public string Name { get; set; }
        public int Edition { get; set; }
        public string Category { get; set; }
      public void GetDataFromUser()
        {
          
            Console.WriteLine("Enter Book Auther Name: ");
            string autherName = Console.ReadLine();
            Console.WriteLine("Enter Book Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Book Edition: ");
            int edition = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Book Category: ");
            string category = Console.ReadLine();
            Id = Id + 1;
            AutherName = autherName;
            Name = name;
            Edition = edition;
            Category = category;

        }
        public override string ToString()
        {
            return $"Id: {Id}," +
                $" Auther Name: {AutherName}," +
                $" Name: {Name}," +
                $" Edition: {Edition}, " +
                $"Category: {Category}";
        }


    }


}
