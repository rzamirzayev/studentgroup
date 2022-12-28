using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    internal class StudentService : Stundent
    {
        Stundent s = new();

        public void Create()
        {

            Console.Write("Adinzi daxil edin:");
            s.name = Console.ReadLine();
            



            Console.Write("Soyadinizi daxil edin:");
            s.surname = Console.ReadLine();
            Array.Resize(ref Group.Students, Group.Students.Length + 1);
            {
                Group.Students[Group.Students.Length - 1] = s.name+s.surname;
            }

            bool controlname = false;
            bool controlsurname = false;
            if (s.name.Length >= 3 && s.name.Length < 15)
            {
                controlname = true;

                id++;
                if (s.surname.Length >= 3)
                {
                    controlsurname = true;
                    id++;

                }
                Console.WriteLine("Idiniz:" + ((id / 2)-1));

            }

        }
        public void Delete()
        {
            Console.Write("Silmek istediyiniz id qeyd edin:");
            int deleteid = Convert.ToInt32(Console.ReadLine());
            
            Group.Students[(deleteid)] =string.Empty;
            

        }
        public void Edit()
        {
            Console.WriteLine("Deyismek istediyiniz idini daxil edin:");
            int editid = Convert.ToInt32(Console.ReadLine());
            string ad;
            string soyad;
            Console.WriteLine("Deyismek istediyinz adi daxil edin.");
            ad= Console.ReadLine(); 
            
            Console.WriteLine("Deyismek istediyiniz soyadi daxil edin.");
            soyad= Console.ReadLine();
            Group.Students[editid] = ad + soyad;
            




        }
        public void GetAll()
        {
            foreach(var item in Group.Students)
            {
                Console.WriteLine(item);
            }

              
                    
                    
                
            }
        public void GetById()
        {
            Console.WriteLine("Yoxlamaq istediyinz id daxil edin");
            int idcontrol = Convert.ToInt32(Console.ReadLine());
            try
            {

                Console.WriteLine(Group.Students[idcontrol]);

            }
            catch
            {
                Console.WriteLine("Bu indexli id yoxdur");
            }
            
        }
        }


    }

