using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    class StudentData
    {
        private static Student _TestStudent;

        public static Student TestStudent
        {
            get
            {
                return _TestStudent;
            }
            private set
            {

            }
        }
    }
}