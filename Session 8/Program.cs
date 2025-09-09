namespace Session_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact person1 = new Contact();
            person1.Name = "Kal-El";
            person1.Address = "30 Aberdeen St";
            person1.Email = "kal-el@email.com";
            Contact person2 = new Contact()
            {
                Name = "Chris",
                Address = "30 Aberdeen St",
                Email = "chris.arnold@nmtafe.wa.edu.au"
            };
            ContactCSVStorage csvWriter = new ContactCSVStorage("..\\..\\..\\data.csv");
            //csvWriter.SaveContacts(new Contact[] { person1, person2 });

            Contact[] fromFile=csvWriter.ReadContacts();
            foreach (Contact contact in fromFile)
            {
                Console.WriteLine(contact.Name);
            }
        }



        void DoGeometryThings()
        {
            {
                Rectangle rectangle = new Rectangle(3, 7);
                Rectangle rectangle2 = new Rectangle(4, 10);
                Console.WriteLine(rectangle.GetArea());
                Console.WriteLine(rectangle2.GetArea());
                Square square1 = new Square(7);
                Console.WriteLine(square1.GetArea());
            }
        }
    }
}
