using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using uams.BL;

namespace uams.DL
{
    class degreeProgramDL
    {
       public static List<DegreeProgram> programList = new List<DegreeProgram>();
        public static void addDegreeInList( DegreeProgram program)

        {
            programList.Add(program);
        }
        public static DegreeProgram isDegreeExist(string degree)
        {
            foreach(DegreeProgram d in programList)
            {
                if(d.titelD==degree)
                {
                    return d;
                }
            }
            return null;
        }
        public static void storeIntoFile(DegreeProgram d)
        {
            string path = "degree.txt";
            StreamWriter f = new StreamWriter(path, true);
            string subjectNames = "";
            for(int x=0;x<d.subjects.Count-1;x++)
            {
                subjectNames = subjectNames + d.subjects[x].subjectType + ";";
            }
            subjectNames = subjectNames + d.subjects[d.subjects.Count - 1].subjectType;
            f.WriteLine(d.titelD + "," + d.duration+","+d.seats+","+ subjectNames);
            f.Flush();
            f.Close();

        }
        public static bool readDataFromFile()
        {
            string path = "degree.txt";
            StreamReader f = new StreamReader(path, true);
            string record;
            if(File.Exists(path))
            {
                while((record=f.ReadLine())!=null)
                {
                    string[] splittedRecord = record.Split(',');
                    string degreeName = splittedRecord[0];
                    int degreeDuration = int.Parse(splittedRecord[1]);
                    int seat = int.Parse(splittedRecord[2]);
                    string[] splittedRecordforSubject = splittedRecord[3].Split(';');
                    DegreeProgram d = new DegreeProgram(degreeName, degreeDuration, seat);
                    for(int x=0;x< splittedRecordforSubject.Length;x++)
                    {
                        Subject s = subjectDL.isSubjectExist(splittedRecordforSubject[x]);
                        if(s!=null)
                        {
                            d.AddSubject(s);
                        }
                    }
                    addDegreeInList(d);
                }
                f.Close();
                return true;
            }
            return false;
        }
    }
}
