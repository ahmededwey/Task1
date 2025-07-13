namespace D05
{
    class Visitor
    {    
        public string Name { get; set; }
        public string Email { get; set; }
        public long PhoneNumber { get; set; }
        // Default Constructor
        public Visitor()
        {
            Name = string.Empty;
            Email = string.Empty;
            PhoneNumber = 0;
        }
        // Parameterized Constructor    
        public Visitor(string name, string email, long phoneNumber)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }
        // Copy Constructor
        public Visitor(Visitor visitor)
        {
            Name = visitor.Name;
            Email = visitor.Email;
            PhoneNumber = visitor.PhoneNumber;
        }
  

        public void GetDataFromUser()
        {
            Console.WriteLine("Enter Visitor Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Visitor Email: ");
            Email = Console.ReadLine();
            Console.WriteLine("Enter Visitor Phone Number: ");
            PhoneNumber = long.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return $"Name: {Name}," +
                $" Email: {Email}," +
                $" Phone Number: {PhoneNumber}";
        }


    }
}
