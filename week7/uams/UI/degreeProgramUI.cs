using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uams.DL;
using uams.BL;

namespace uams.UI
{
    class degreeProgramUI
    {
        //subject menu
        subjectUI subject = new subjectUI();
        public  DegreeProgram takeInPutForDegree()
        {
            List<Subject> subjects = new List<Subject>();
            Console.WriteLine("enter degree name: ");
            string name = Console.ReadLine();
            Console.WriteLine("enter degree Duration: ");
            int duration = int.Parse(Console.ReadLine());
            Console.WriteLine("enter Seats for Degree: ");
            int seat = int.Parse(Console.ReadLine());
            DegreeProgram program = new DegreeProgram(name, duration, seat);

            Console.WriteLine("enter how many subject you want to add");
            int subNum = int.Parse(Console.ReadLine());
            for (int x = 0; x < subNum; x++)
            {
                Subject s = subject.takeInPutForSubject();
         if(program.AddSubject(s))
                {
                    if(!(subjectDL.subjects.Contains(s)))
                        {
                        subjectDL.storeIntoFile(s);
                        subjectDL.storesubjectIntoList(s);
                    }
                }
                else
                {
                    Console.WriteLine("try again");
                }

            }
            return program;
        }


        public  void viewProgram(List<DegreeProgram> programs)
        {
            Console.WriteLine("available programs is");
            foreach (DegreeProgram p in programs)
            {
                Console.WriteLine(p.titelD);
            }
        }
    }
}
