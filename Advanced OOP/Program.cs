namespace Advanced_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //Test ALL Classes
            Console.WriteLine("--------------Task 1-------------");
            Person person = new Person();
            person.Name = "Ahmad";
            person.Age = 25;
            person.PrintUserInfo();
            Student student = new Student();
            student.Name = "Yasmeen";
            student.Age = 26;
            student.Mark = 95;
            student.PrintStudentInfo();
            //Task 2
            Console.WriteLine("--------------Task 2-------------");

            Car rangeRover = new Car(
                   "Land Rover",
                    2024,
                   "SUV",
                    95000,
                   "Range Rover Autobiography",
                   "RNG-7890",
                    "Black"
                      );

          
            rangeRover.StartEngine();
            rangeRover.GetCarInfo();
            rangeRover.StopEngine();

        }
    }
}
