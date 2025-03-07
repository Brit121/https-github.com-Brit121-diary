namespace diary
{
    internal class Program
    {
        static List<string> diaryEntries = new List<string>();
        static void Main(string[] args)  
        {
            Console.WriteLine("Hello, Welcome to your diary!");
            //passcode, add entry, view entries, delete entries, exit

            int passcode = 1201;
            int password;
            while (true)
            {
                Console.WriteLine("\nPlease enter your passcode: ");
                if (int.TryParse(Console.ReadLine(), out password) && password == passcode)
                {
                    Console.WriteLine("\nLogged In Successfully!");
                    break;
                }
                else
                {
                    Console.WriteLine("\nWrong Passcode. Please Try Again!");
                }
            }
                while (true)
                {
                    Console.WriteLine("\n Options: ");
                    Console.WriteLine("[1] Add an Entry");
                    Console.WriteLine("[2] View Entries");
                    Console.WriteLine("[3] Delete Entry");
                    Console.WriteLine("[4] Exit");

                    Console.WriteLine("\nPlease choose an option: ");
                    string option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            Console.WriteLine("\nAdd an entry: ");
                            string entry = Console.ReadLine();
                            diaryEntries.Add(entry);
                            Console.WriteLine("Entry Added Successfully!");
                            break;

                        case "2":
                            if (diaryEntries.Count == 0)
                            {
                                Console.WriteLine("\nNo Entries found.");
                                continue;
                            }
                            Console.WriteLine("\nEntries: ");
                            for (int i = 0; i < diaryEntries.Count; i++)
                            {
                                Console.WriteLine($"\n{i + 1}. {diaryEntries[i]}");
                            }
                            break;

                        case "3":
                            if (diaryEntries.Count == 0)
                            {
                                Console.WriteLine("\nNo Entries to delete.");
                                continue;
                            }
                            Console.WriteLine("\nEntries: ");
                            for (int i = 0; i < diaryEntries.Count; i++)
                            {
                                Console.WriteLine($"\n{i + 1}. {diaryEntries[i]}");
                            }
                            Console.WriteLine("\nPlease enter the number of the entry you want to delete:  ");
                            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= diaryEntries.Count)
                            {
                                diaryEntries.RemoveAt(index - 1);
                                Console.WriteLine("\nEntry deleted successfully!");
                            }
                            else
                            {
                                Console.WriteLine("\nInvalid number of entry! Please Try Again.");
                            }
                            break;

                        case "4":
                            Console.WriteLine("\nExiting... Byebye!!!");
                            return;

                        default:
                            Console.WriteLine("\nInvalid option. Please try again!");
                            break;
                    }

                }
            }
      }
    }