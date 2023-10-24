namespace _23102023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntList intList = new IntList();

            intList.Add(1);
            intList.Add(22);
            intList.Add(35);
            intList.Add(135);

            int[] ints = new int[] { 66, 77, 88 };

            intList.AddRange(ints);

            foreach (var item in intList._intArr)
            {
                Console.WriteLine(item);
            }

            StringList stringList = new StringList();

            stringList.Add("1");
            stringList.Add("2");
            stringList.Add("3");

            string[] strings = new string[] { "Yusif", "Eli" };

            stringList.AddRange(strings);

            //MyList<int> myList = new MyList<int>();

            //myList.Add(4);

            //MyList<string> strList = new MyList<string>();

            //strList.Add("Tanzile");

            MyList<Human> humanList = new MyList<Human>();

            MyList<Animal> myList1 = new MyList<Animal>();

            humanList.Add(new Human() { Name = "Eli" });

            PhoneList<string, string> phoneList = new PhoneList<string, string>();

            phoneList.Add("Enver Zohrabov", "055-555-55-55");
            phoneList.Add("Inci Zohrabova", "055-555-55-56");

            for (int i = 0; i < phoneList.Names.Length; i++)
            {
                Console.WriteLine(phoneList.Names[i] + " - " + phoneList.PhoneNumbers[i]);
            }
        }
    }
}