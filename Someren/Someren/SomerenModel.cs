using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Someren
{
    class SomerenModel
    {
    //Begin student classes
        public class Student
        {
            int id;
            string naam;

            public void setNaam(string naamStudent)
            {
                naam = naamStudent;
            }

            public string getNaam()
            {
                return naam;
            }

            public int getId()
            {
                return id;
            }
            
        }

        public class StudentList
        {
            List<SomerenModel.Student> sl = new List<SomerenModel.Student>();
            
            public void addList(SomerenModel.Student s) {
                sl.Add(s);
            }

            public List<SomerenModel.Student> getList()
            {
                return sl;
            }
        }

        //Begin docent classes
        public class Docent
        {
            int id;
            string naam;
            string achterNaam;

            public void setNaam(string naamDocent)
            {
                naam = naamDocent;
            }
            public string getNaam()
            {
                return naam;
            }

            public void setAchterNaam(string AchterNaamDocent)
            {
                achterNaam = AchterNaamDocent;
            }
            public string getAchterNaam()
            {
                return naam;
            }

            public void setId(int idDocent)
            {
                id = idDocent;
            }
            public int getId()
            {
                return id;
            }

        }

        public class DocentList
        {
            List<SomerenModel.Docent> dl = new List<SomerenModel.Docent>();
          
            public void addList(SomerenModel.Docent d)
            {
                dl.Add(d);
            }

            public List<SomerenModel.Docent> getList()
            {
                return dl;
            }
        }

    }
}
