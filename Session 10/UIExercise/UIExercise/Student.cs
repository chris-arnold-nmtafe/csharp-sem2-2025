using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIExercise
{
    public class Student
    {
        public const int STATUS_ENROLLED = 0;
        public const int STATUS_WITHDRAWN = 1;

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EnrolmentStatus Enrolment { get; set; }

        public Student()
        {

        }

        public Student(int id, string firstName, string lastName, EnrolmentStatus status)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Enrolment = status;
        }


        public void ErrolStudent()
        {
            //Enrolment = EnrolmentStatus.Enrolled;
            FirstName = "Errol";
        }

        public void Withdraw()
        {
            Enrolment = EnrolmentStatus.Withdrawn;
        }

        /// <summary>
        /// TODO: Override to change how the student is displayed in a list.
        /// Return a custom string using the properties above to visually represent the Student.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{LastName} {FirstName} ({Enrolment})";
        }

    }

    public enum EnrolmentStatus
    {
        NotEnrolled = 0,
        Pending = 1,
        Paid = 2,
        Enrolled = 3,
        Failed = 4,
        Withdrawn = 5
    }
}
