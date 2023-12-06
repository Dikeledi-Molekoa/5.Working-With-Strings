namespace _5.Working_With_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("This will write same line");
            Console.WriteLine("This \n will wrap to the next line");
            Console.WriteLine("This \" will print out the quotation mark");

            string firstName = "Dikeledi";
            string lastName = "Molekoa";

            //concatination
            Console.WriteLine(firstName + " " + lastName);

            //funtions with strings
            Console.WriteLine(lastName.Length);

            //methods with strings
            Console.WriteLine(firstName.ToUpper());

            //method with a paremeter eg the contains(), it's case sensitive
            Console.WriteLine(lastName.Contains("fu"));

            //access characters using index
            Console.WriteLine(firstName[0]);

            //indexOf will tell u if the value is there and at what position
            Console.Write("The index of a is ");
            Console.WriteLine(lastName.IndexOf('a')); // can use double quotes too


            //substring, to grab from an index onwards
            Console.WriteLine(firstName.Substring(1));

            //you can also give index and length ie how many chars u wanna grab
            Console.WriteLine(firstName.Substring(1,2));

            Console.Read();



        }
    }
}
