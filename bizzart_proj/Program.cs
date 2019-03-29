using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bizzart_proj
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            using (ArtGalletyContext db = new ArtGalletyContext())
            {
                User userAdmin = new User { Name = "Saryal", Role = "Admin", BirthDate = new DateTime(1998, 5, 4), EmploymentDate = new DateTime (2018, 12, 12)};
                db.Users.Add(userAdmin);
                db.SaveChanges();
                Console.WriteLine("Changes sanved successfuly");
                var users = db.Users;
                Console.WriteLine("Список объектов:");
                foreach (User u in users)
                {
                    Console.WriteLine("{0}.{1} - {2}", u.Id, u.Name, u.EmploymentDate);
                }
            }
            Console.Read();
        }
    }
}
