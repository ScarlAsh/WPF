using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_wpf_app
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Image { get; set; }

		public override string ToString()
		{
            return Name; 
		}
	}
}
