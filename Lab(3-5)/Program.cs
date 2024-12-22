using System.Net;
using System.Text.Json;
using System.Text.Json.Nodes;
using static System.Reflection.Metadata.BlobBuilder;

namespace Lab_3_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1 

            // Mushteri elave olunur, novbede ilk mushteri chagirilir, Novbedeki mushterilerin siyahisi gosterilir //

            //Custom custom1 = new Custom();
            //custom1.name = "Mushteri1";
            //Custom custom2 = new Custom();
            //custom2.name = "Mushteri2";
            //Custom custom3 = new Custom();
            //custom3.name = "Mushteri3";
            //Queue<Custom> queue = new Queue<Custom>();
            //queue.Enqueue(custom1);
            //queue.Enqueue(custom2);
            //queue.Enqueue(custom3);
            //queue.Dequeue();

            //foreach (Custom item in queue)
            //{
            //    Console.WriteLine("\n" + item.name);
            //}

            #endregion

            #region Task2

            // Console.Readline
            // 1 Ishci elave et(Istifadechi adi,Ishci adi,Shobesi,Maashi,Tecrubesi)
            // 2 Shobe uzre gruplashdir(Ishcileri shobe adi ile gruplashdir ve her grup uchun ishci adi goster)
            // 3 En yuksek maash(Her shobede en yuksek maash alan)
            // 4 Orta maash(Her shobede orta maash alan)
            // 5 Tecrube uzre siralama(Azalan sirada)
            // 0 Chixish

            //int sechim;
            //do
            //{
            //Console.WriteLine("                                                " + "1. Ishci elave et ");
            //    Console.WriteLine("                                                " + "2. Shobe uzre gruplashdir ");
            //    Console.WriteLine("                                                " + "3. En yuksek maash ");
            //    Console.WriteLine("                                                " + "4. Orta maash ");
            //    Console.WriteLine("                                                " + "5. Tecrube uzre siralama ");
            //    Console.WriteLine("                                                " + "0. Chixish ");
            //    Console.Write("                                    " +  "Secim edin: ");
            //    sechim = int.Parse(Console.ReadLine());

            //    switch (sechim)
            //    {
            //        case 1:
            //            AddEmployee();
            //            break;
            //        case 2:
            //            GroupByBranch();
            //            break;
            //        case 3:
            //            HighestSalary();
            //            break;
            //        case 4:
            //            AverageSalary();
            //            break;
            //        case 5:
            //            SortByExperience();
            //            break;
            //        case 0:
            //            Console.WriteLine("Programdan chixilir...");
            //            break;
            //        default:
            //            Console.WriteLine("Yanlis secim. Zehmet olmasa yeniden cehd edin.");
            //            break;
            //    }

            //} while (sechim != 0);

            #endregion

            #region Task3

            Book book1 = new Book()
            {
                Name = "",
                Author = ""

            };
            Book book2 = new Book()
            {
                Name = "",
                Author = ""
            };
            Book book3 = new Book()
            {
                Name = "",
                Author = ""
            };
            int sechim = 0;
            List<Book> list = new List<Book>();
            string path = "C:\\Users\\user\\Desktop\\";
            do
            {
                Console.WriteLine("                                                    " + "1. AddBook ");
                Console.WriteLine("                                                    " + "2. ShowBook ");
                Console.WriteLine("                                                    " + "3. FindBook ");
                Console.WriteLine("                                                    " + "4. DeleteBook ");
                Console.WriteLine("                                                    " + "5. WriteFile ");
                Console.WriteLine("                                                    " + "6. ReadFile ");
                Console.WriteLine("                                                    " + "0. Out ");
                sechim= int.Parse(Console.ReadLine());

                switch (sechim)
                {
                    case 1:

                            Console.Write("Book name: ");
                            string bookName = Console.ReadLine();
                            Console.Write("Author name: ");
                            string authorName = Console.ReadLine();
                            Console.Write("DateTime: ");
                            int dateTime = int.Parse(Console.ReadLine());
                            Book newBook = new Book(bookName, authorName, dateTime);
                            list.Add(newBook);
                            Console.WriteLine("Kitab muveffeqiyetle elave olundu.");
                        
                        break;
                    case 2:
                        list.ForEach(x => Console.WriteLine($"{x.Id},{x.Name},{x.Author},{x.PublicationYear}"));
                        break;
                    case 3:
                        Console.WriteLine("Enter the name to Find");
                        string name = Console.ReadLine();
                        list.FindAll(x => x.Name == name).ForEach(n => Console.WriteLine(n.Name));
                        break;
                    case 4:
                        Console.WriteLine("Enter Delete Book Id");
                        int id = int.Parse(Console.ReadLine());
                        list.FindAll(x => x.Id == id).RemoveAll(x => x.Id == id);
                        break;
                    case 5:
                        Console.WriteLine("Write File");
                        string fileName = Console.ReadLine();
                        //if(!File.Exists(path + fileName))
                        //{
                        //    File.Create(path + fileName);
                        //}
                        string serialize = JsonSerializer.Serialize(list);
                        File.AppendAllLines(path + fileName,new List<string>());
                        using (StreamWriter sm = new StreamWriter(path + fileName, true))
                        {
                            sm.WriteLine(serialize);
                        }
                        break;
                    case 6:
                        Console.WriteLine("Read File");
                        string readFileName = Console.ReadLine(); // Get the filename from the user

                        // Read the file contents and deserialize the JSON data into a list of books
                        using (StreamReader sr = new StreamReader(path + readFileName))
                        {
                            string fileContent = sr.ReadToEnd();
                            list = JsonSerializer.Deserialize<List<Book>>(fileContent);
                        }

                        // Output each book name in the list
                        foreach (var book in list)
                        {
                            Console.WriteLine(book.Name);
                        }

                        break;
                    default:
                        Console.WriteLine("Yanlis secim. Zehmet olmasa yeniden cehd edin.");
                        break ;
                }
            } while (sechim != 0);
            #endregion
        }







        #region Task2

        //static List<Ishci> ishciler = new List<Ishci>();
        //static void AddEmployee() // IshciElaveEle.
        //{
        //    Console.Write("Istifadechi adi: ");
        //    string istifadechiAdi = Console.ReadLine();
        //    Console.Write("Ishci adi: ");
        //    string ishciAdi = Console.ReadLine();
        //    Console.Write("Shobe: ");
        //    string shobe = Console.ReadLine();
        //    Console.Write("Maash: ");
        //    double maash = double.Parse(Console.ReadLine());
        //    Console.Write("Tecrube (yil): ");
        //    int tecrube = int.Parse(Console.ReadLine());

        //    Ishci yeniIshci = new Ishci(istifadechiAdi, ishciAdi, shobe, maash, tecrube);
        //    ishciler.Add(yeniIshci);

        //    Console.WriteLine("Ishci muveffeqiyetle elave olundu.");
        //}

        //static void GroupByBranch() // Shobeuzregruplashdir.
        //{
        //    var groupedByBranch = ishciler.GroupBy(i => i.Shobe);

        //    foreach (var group in groupedByBranch)
        //    {
        //        Console.WriteLine("\n" + $"Shobe: {group.Key}");
        //        foreach (var employee in group)
        //        {
        //            Console.WriteLine($"- {employee.IshciAdi}");
        //        }
        //    }
        //}

        //static void HighestSalary() // Enyuksekmaash.
        //{
        //    var highestSalaryByBranch = ishciler
        //        .GroupBy(i => i.Shobe)
        //        .Select(g => new
        //        {
        //            Shobe = g.Key,
        //            HighestSalaryEmployee = g.OrderByDescending(i => i.Maash).First()
        //        });

        //    foreach (var item in highestSalaryByBranch)
        //    {
        //        Console.WriteLine("\n" + $"Shobe: {item.Shobe}, En yuksek maash: {item.HighestSalaryEmployee.Maash} - {item.HighestSalaryEmployee.IshciAdi}" + "\n");
        //    }
        //}

        //static void AverageSalary() // Ortamaash.
        //{
        //    var averageSalaryByBranch = ishciler
        //        .GroupBy(i => i.Shobe)
        //        .Select(g => new
        //        {
        //            Shobe = g.Key,
        //            AverageSalary = g.Average(i => i.Maash)
        //        });

        //    foreach (var item in averageSalaryByBranch)
        //    {
        //        Console.WriteLine("\n" + $"Shobe: {item.Shobe}, Orta maash: {item.AverageSalary:F2}");
        //    }
        //}

        //static void SortByExperience() // Tecrubeuzresirala.
        //{
        //    var sortedByExperience = ishciler
        //        .OrderByDescending(i => i.Tecrube)
        //        .ToList();

        //    Console.WriteLine("Tecrube uzre siralanmis ishciler:" + "\n");
        //    foreach (var employee in sortedByExperience)
        //    {
        //        Console.WriteLine($"Ishci: {employee.IshciAdi}, Tecrube: {employee.Tecrube} yil" + "\n");
        //    }
        //}

        #endregion

        #region Task3

        

        #endregion


    }
}
