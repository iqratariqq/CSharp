using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uams.BL;

namespace uams.UI
{
    class subjectUI
    {
        public  Subject takeInPutForSubject()
        {

            Console.WriteLine("enter subject code:");
            string code = Console.ReadLine();
            Console.WriteLine("enter subject type:");
            string type = Console.ReadLine();
            Console.WriteLine("enter subject cradit hours:");
            int hour = int.Parse(Console.ReadLine());
            Console.WriteLine("enter subject fee:");
            int fee = int.Parse(Console.ReadLine());
            Subject subject = new Subject(code, type, hour,  fee);
            return subject;
        }

        public void registerSubject(Student s)
        {
            Console.WriteLine("enter how many subject you want to refister");
            int Count = int.Parse(Console.ReadLine());
            for (int x = 0; x < Count; x++)
            {
                Console.WriteLine("Enter the subject code");
                string code = Console.ReadLine();
                bool flag = false;
                foreach (Subject sub in s.registerDeg.subjects)
                {
                    if (code == sub.code && !(s.regsubjects.Contains(sub)))
                    {
                        if (s.regStudentSubject(sub))
                        {
                            flag = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("A student cannot have more than 9 cradit hour");
                            flag = true;
                            break;
                        }
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("enter a valid code");
                    x--;
                }
            }

        }

    }
}
