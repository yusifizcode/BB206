namespace Inheritance_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task 1
            //Human class:
            //============
            //string Name
            //string Surname;
            //byte Age (encapsulation)


            //User class:
            //===========
            // - UserName - istifadəçinin istifadəçi adını ifadə edir
            // - Password - İstifadəçinin şifrə dəyərini ifadə edir


            //User classi Human'dan miras alir. Name, Surname, UserName dəyəri təyin olunmamış User obyekti yaradıla bilinməməlidir.UserName dəyərinin uzunluğu minimum 6, maksimum 25 ola bilər.
            //Password dəyərinin uzunluğu minimum 8 , maksimum 25 ola bilər.


            //Daha sonra User type-da olan obyekt yaradın, bunun üçün username və password dəyərlərini console-dan qəbul edin.
            #endregion

            #region Task 2
            //Product class:
            //==============
            //string Name
            //string Description
            //int Count
            //bool IsStock
            //double Price (encapsulation)
            //Sale() -> satış methodu

            //Notebook class:
            //===============
            //byte RAM (encapsulation)
            //int Storage

            //GetFullInfo()
            //ShowFullData()

            //Notebook classi Product'dan miras alir. Name, Count, Price,
            //RAM deyerleri daxil edilmeden, Notebook obyekti yaradila bilmez.
            //Notebook obyekti yaradib Sale() methodunu işə salırsınız, əgər məhsul stockda yoxdursa,
            //"Məhsul yoxdur!" yazısını ekrana çıxarırsınız. Daha sonra ShowFullData() methodunu işə salıb,
            //bütün dataları ekranda göstərirsiniz.
            #endregion

            #region Task 3
            //Vehicle class:
            //==============
            //string Brand -> 3den boyuk, 30dan kicik olmalidir
            //string Model -> 3den boyuk, 30dan kicik olmalidir
            //double Mile -> 0-dan boyuk olmalidir.

            //Car class: Vehicle
            //int DoorsNum -> (0dan boyuk, 5den kicik olmalidir)
            //ShowFullInfo()

            //Bicycle class: Vehicle
            //int WheelNum -> (0dan boyuk, 5den kicik olmalidir)
            //ShowFullInfo()


            //Brand ve Model teyin edilmeden, Car ve Bicycle obyekti yaratmaq olmasin.
            #endregion

            //string name = Console.ReadLine();
            //string surName = Console.ReadLine();
            //string userName = Console.ReadLine();


            //User user = new User(name, surName, userName);

            Notebook notebook = new Notebook()
            {
                Name = "Lenovo",
                Description = "Bomba komputerdi",
                Price = 3000,
                Count = 3
            };

            notebook.ShowFullData();

            notebook.Sale();
            notebook.Sale();
            notebook.Sale();
            notebook.Sale();

            if (!notebook.IsStock)
            {
                Console.WriteLine("Mehsul bitib!");
            }

            notebook.ShowFullData();

            Car car = new Car("Tesla", "Model X");
            car.DoorsNum = 4;
            Bicycle bicycle = new Bicycle("Velo", "Velo");
            bicycle.WheelNum = 2;

            //car.ShowFullInfo();
            bicycle.ShowFullInfo();
        }
    }
}