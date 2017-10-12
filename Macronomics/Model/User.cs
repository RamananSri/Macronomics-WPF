using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macronomics.Model
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

        private Gender gender;

        public Gender GetGender()
        {
            return gender;
        }

        public void SetMyProperty(Gender value)
        {
            gender = value;
        }
    }
    public enum Gender
    {
        Male, Female
    }
}
