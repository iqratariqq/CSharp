using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using uams.BL;

namespace uams.DL
{
    class subjectDL
    {
        public static List<Subject> subjects = new List<Subject>();

        public static void storesubjectIntoList(Subject sub)
        {
            subjects.Add(sub);
        }
        public static bool readFromFile()
        {
            string path = "subject.txt";
            StreamReader f = new StreamReader(path, true);
            string record;
            if(File.Exists(path))
            {
                while((record=f.ReadLine())!=null)
                {
                    string[] splittedRecord = record.Split(',');
                    string code = splittedRecord[0];
                    string type = splittedRecord[1];
                    int craditHour = int.Parse(splittedRecord[2]);
                    int subjectFee = int.Parse(splittedRecord[3]);
                    Subject s = new Subject(code, type, craditHour, subjectFee);
                    storesubjectIntoList(s);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeIntoFile(Subject s)
        {
            string path = "subject.txt";
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(s.code + "," + s.subjectType + "," + s.creditHours + "," + s.subjectFee);
            f.Flush();
            f.Close();
        }
        public static Subject isSubjectExist(string type)
        {
            foreach(Subject sub in subjects)
            {
                if(sub.subjectType==type)
                {
                    return sub;
                }
            }
            return null;
        }
    }
}
