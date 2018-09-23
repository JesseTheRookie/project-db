using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Someren
{
    class SomerenModel
    {

        // Begin student classes
            public class Student
            {
                int id;
                string naam;
                string achternaam;


                public void setId(int IdStudent)
                {
                    id = IdStudent;
                }
                public void setNaam(string naamStudent)
                {
                    naam = naamStudent;
                }
                public void setAchterNaam(string AchternaamStudent)
                {
                    achternaam = AchternaamStudent;
                }

                public string getNaam()
                {
                    return naam;
                }

                public int getId()
                {
                    return id;
                }

                public string getAchternaam()
                {
                    return achternaam;
                }

            }

            public class StudentList
            {
                List<SomerenModel.Student> sl = new List<SomerenModel.Student>();

                public void addList(SomerenModel.Student s)
                {
                    sl.Add(s);
                }

                public List<SomerenModel.Student> getList()
                {
                    return sl;
                }
            }


            // Begin docent classes
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

                public void setAchternaam(string AchternaamDocent)
                {
                    achterNaam = AchternaamDocent;
                }
                public string getAchternaam()
                {
                    return achterNaam;
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

