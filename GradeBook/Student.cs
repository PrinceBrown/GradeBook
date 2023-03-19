using System;
namespace GradeBook
{
	public class Student
	{

		public string Name { get; set; }
		public double Age { get; set; }
	 





        public Student(string name, double age)
		{
        
            Name = name;
			Age = age;
		}








		public string Info()
		{
			return $"{Name}, {Age}, child: {CheckIsAChild()}";

		}


 



        public bool CheckIsAChild()
		{
			if(Age < 16)
			{
				return true;
			}
	 
                return false;
			
		}






        public void About()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Downloaded Studed Personal & Family Profile");
            Console.WriteLine("---------------------------------");
            string isChildResult = (CheckIsAChild()) ? "Yes" : "No";

            Console.WriteLine($"Name of Child: {Name}");
            Console.WriteLine($"Details: {Info()}");
            Console.WriteLine($"Check Is A Child: {isChildResult}");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("----------FAMILY INFORMATION-------------");
            Console.WriteLine("updating data from family database directory...");
            Console.WriteLine("This is a great family the world knows about");

            Console.ReadLine();
        }


        public void EditName(string newName)
        {
            Name = newName;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("-----------success----------------");
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Your student's has been updated successfully to {Name}");
 

            Console.WriteLine("---------------------------------");
            Console.WriteLine(Info());
        

            Console.ReadLine();
            
        }



    }
}

