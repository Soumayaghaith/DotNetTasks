namespace OOPA2
{
    internal class Program
    {
        struct person
        { 
            public string name;
            public int age;

            //constructor
            public person(string In_name, int In_age)
            { 
                name = In_name; 
                age = In_age;
            }

            //Method for displaying
            public void display()
            {
                Console.WriteLine($"Name: {name}, Age: {age}");
            }
        
        }
        static void Main(string[] args)
        {
            #region Q1
            //Define a struct "Person" with properties "Name" and "Age". Create an array of
            //three "Person" objects and populate it with data. Then, write a C# program to
            //display the details of all the persons in the array.
            person[] persons = new person[3];
            persons[0] = new person("Sarah",25);
            persons[1] = new person("Lamisse",12);
            persons[2] = new person("Nadine",26);

            Console.WriteLine("Persons info:");
            foreach (person person in persons)
            {
                person.display();
            }



            #endregion
        }
    }
}
