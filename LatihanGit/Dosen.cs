using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanGit
{
    public class Dosen 
    {
        private int id;
        private string Nama;
        private int Nik;
        private string Gender;
        private string Course;

        public Dosen()
        {
           id = 1;
           Nama = "Dosen Pengampu";
           Nik = 123456789;
           Gender = "Male";
           Course = "Pemrograman Berorientasi Objek";
        }
       
        public void attDosen(string nama, int nik)
        {
            Nama = nama;
            Nik = nik;
        }

        public void addCourse(string newCourse)
        {
            Course += ", " + newCourse;
        }

        public void display()
        {
            Console.WriteLine("ID      : " + id);
            Console.WriteLine("Nama    : " + Nama);
            Console.WriteLine("Nik     : " + Nik);
            Console.WriteLine("Gender  : " + Gender);
            Console.WriteLine("Course  : " + Course);
        }
    }
}
