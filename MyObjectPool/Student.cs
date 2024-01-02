using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObjectPool
{
    internal class Student
    {
        private string firstName;
        private int studentID;

        public string getName()
        {
            return firstName;
        }

        public void setName(string name)
        {
            firstName = name;
        }

        public int getStudentID() 
        {
            return studentID;
        }

        public void setStudentID(int id)
        {
            studentID = id;
        }
    }
}
