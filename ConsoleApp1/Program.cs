
#region Fibanocci

//Fibonocci(5);



//static void Fibonocci(int n)
//{
//    int a = 0;
//    int b = 1;
//    int c;


//    Console.WriteLine(a);
//    Console.WriteLine(b);


//    for (int i = 1; i <= n; i++)
//    {
//        c = a + b;

//        a = b;
//        b = c;

//        Console.WriteLine(c);

//    }

//}

#endregion


using ConsoleApp1;
using ConsoleApp1.Models;

//Manat manat = new Manat(340);

//Dollar dollar = manat;
//Console.WriteLine(dollar.Usd);


//Dollar dollar =(Dollar) manat;


//StringList list1 = new StringList();

//list1.Add("Roya");
//list1.Add("Konul");
//list1.Add("Cinarew");
//list1.GetAll();


//IntList list2 = new IntList();

//list2.Add(1);
//list2.Add(2);
//list2.Add(3);
//list2.Add(4);

//list2.GetAll();



//DataList<string> students = new DataList<string>();

//students.Add("Roya");
//students.Add("Konul");
//students.Add("Cinarew");

//students.GetAll();


//DataList<int> numbers = new DataList<int>();

//numbers.Add(1);
//numbers.Add(2);
//numbers.Add(3);
//numbers.Add(4);

//numbers.GetAll();



//StudentList list3 = new StudentList();

//list3.Add (new Student { Id = 1, Name = "Ali" });
//list3.Add(new Student { Id = 2, Name = "Aksin" });
//list3.Add(new Student { Id = 3, Name = "Elcan" });

//list3.GetAll();


//DataList<Student> studentList = new DataList<Student>();

//studentList.Add(new Student { Id = 1, Name = "Ali" });
//studentList.Add(new Student { Id = 2, Name = "Aksin" });
//studentList.Add(new Student { Id = 3, Name = "Elcan" });

//studentList.GetAll();



//List<int> nums = new List<int>();

//nums.Add(100);
//nums.Add(22);


//foreach(var item in nums)
//{
//    Console.WriteLine(item);
//}

//for (int i = 0; i <= nums.Count; i++)
//{
//    for(int j = i + 1; j<= nums.Count - 1; j++)
//    {
//        if (nums[i] > nums[j])
//        {
//            Console.WriteLine("Boyukdur");
//            break;
//        }

//    }


////}


//Repository<Student> student = new Repository<Student>();

//Repository<int> num = new Repository<int>();

//Repository<string> str = new Repository<string>();

//Repository<bool> married = new Repository<bool>();




Repository<Test1, Test2> data = new Repository<Test1, Test2>();

