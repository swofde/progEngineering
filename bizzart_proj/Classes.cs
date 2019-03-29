using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace bizzart_proj
{
    public class Artist
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public int BirthDate { get; set; }
        public int DeathDate { get; set; }
        public String BirthPlace { get; set; }
        public String Biography { get; set; }
        public Picture Picture { get; set; }
    }

    public class Picture
    {
        [Key]
        public int Id { get; set; }
        public String Genre { get; set; }
        public int ArtistId { get; set; }
        public int WriteDate { get; set; }
        public int Price { get; set; }
        public float Size { get; set; }
        public Department Department { get; set; }
        public String PictureHistory { get; set; }
    }

    public class Department
    {
        [Key]
        public int Id { get; set; }
        public int Name { get; set; }
    }

    public class Gallery
    {
        [Key]
        public int Id { get; set; }
        public Department[] Departments { get; set; }
    }

    public class User
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime EmploymentDate { get; set; }
        public String Role { get; set; }
    }
}
