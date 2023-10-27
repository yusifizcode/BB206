namespace FileDirectoryClassWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\User\\Desktop";
            DirectoryInfo directory = new DirectoryInfo(path);


            string ans;
            do
            {
                Console.WriteLine("1. Folder Yarat\n" +
                                  "2. Fayl Yarat\n" +
                                  "3. Exit");

                ans = Console.ReadLine();

                switch (ans)
                {
                    case "1":
                        CreateFolder(path);
                        break;
                    case "2":
                        CreateFile(path, out string fileName, out bool isExist);
                        if (isExist == false)
                        {
                        DoYouWantWriteAText:
                            Console.WriteLine("Yazi yazmaq isteyirsiniz mi? yes/no");
                            string yesNo = Console.ReadLine();
                            if (yesNo.ToLower() == "yes")
                            {
                                Console.WriteLine("Yazini daxil et: ");
                                string content = Console.ReadLine();
                                File.WriteAllText(path + $"\\{fileName}.txt", content);
                                goto DoYouWantWriteAText;
                            }
                            else if (yesNo.ToLower() == "no")
                            {
                                string text = File.ReadAllText(path + $"\\{fileName}.txt");
                                Console.WriteLine(text);
                            }
                        }
                        break;
                    case "3":
                        foreach (var item in directory.GetDirectories())
                        {
                            Console.WriteLine($"{item.Name} - {item.CreationTime}");
                        }
                        break;
                    default:
                        break;
                }

            } while (ans != "3");
        }

        public static void CreateFolder(string path)
        {
            Console.WriteLine("Folderin adini daxil edin: ");
            string folderName = Console.ReadLine();
            DirectoryInfo directoryInfoForFolder = new DirectoryInfo(path + $"\\{folderName}");
            if (!directoryInfoForFolder.Exists)
                directoryInfoForFolder.Create();
            else
                Console.WriteLine("Bu adda folder movcuddur!");
        }

        public static void CreateFile(string path, out string fileName, out bool isExist)
        {
            Console.WriteLine("Faylin adini daxil edin: ");
            fileName = Console.ReadLine();

            FileInfo fileInfo = new FileInfo(path + $"\\{fileName}.txt");
            if (!fileInfo.Exists)
            {
                fileInfo.Create().Close();
                isExist = false;
            }
            else
            {
                Console.WriteLine("Bu adda file movcuddur!");
                isExist = true;
            }
        }
    }
}