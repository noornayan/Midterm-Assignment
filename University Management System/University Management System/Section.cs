using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{

    class Section : Course
    {
        private string secName;

        public string SecName
        {
            get { return secName; }
            set { secName = value; }
        }
        
        protected double sectionTeachingHours;
        public double SectionTeachingHours
        {
            get { return sectionTeachingHours; }
            set { sectionTeachingHours = value; }
        }
        public Section() { }
        public Section(string secName, string courseName, int courseId, int courseCredit, double courseTeachingHours)
            : base(courseName, courseId, courseCredit, courseTeachingHours)
        {
            this.secName = secName;
            this.sectionTeachingHours  = sectionTeachingHours;
        }
        virtual public void ShowSectionInfo()
        {
            Console.WriteLine("Sec Name : " + secName);

        }
    }
}
