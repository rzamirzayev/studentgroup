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
            Array.Resize(ref Group.Students, Group.Students.Length + 1);
            {
                Group.Students[Group.Students.Length - 1] = s.name;
            }



            Console.Write("Soyadinizi daxil edin:");
           s.surname = Console.ReadLine();
            Array.Resize(ref Group.Students, Group.Students.Length + 1);
            {
                Group.Students[Group.Students.Length - 1] = s.surname;
            }

            bool controlname = false;
            bool controlsurname=false;  
            if(s.name.Length>=3 && s.name.Length<15)
            {
                controlname= true;
                id++;
               
                if (s.surname.Length >= 3)
                {
                    controlsurname= true;
                    id++;
                 
                }
                Console.WriteLine("Idiniz:"+id/2);
                
            }
     
        }
        public void Delete()
        {
            Console.Write("Silmek istediyiniz id qeyd edin:");
            int deleteid = Convert.ToInt32(Console.ReadLine());
            bool idcontrol = false;
            Group.Students[(deleteid * 2)] = string.Empty;
            Group.Students[(deleteid * 2) + 1] = string.Empty;
   
        }
        public void Edit()
        {
            Console.WriteLine("Deyismek istediyiniz idini daxil edin:");
            int editid = Convert.ToInt32(Console.ReadLine());
       


        }
        public void GetAll()
        {
            foreach (var item in Group.Students)
            {
                Console.WriteLine(item);
            }
        }
       

    }
}
