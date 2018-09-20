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

            public void setNaam(string naamDocent)
            {
                naam = naamDocent;
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

        public class DocentList
        {
            List<SomerenModel.Docent> sl = new List<SomerenModel.Docent>();

            public void addList(SomerenModel.Docent s)
            {
                sl.Add(s);
            }

            public List<SomerenModel.Docent> getList()
            {
                return sl;
            }
        }

    }
}
