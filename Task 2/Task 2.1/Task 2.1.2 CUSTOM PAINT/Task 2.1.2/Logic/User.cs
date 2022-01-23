using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._1._2.Abstract;
namespace Task_2._1._2.Logic
{
    public class User
    {
        public User() { }
        public string Name { get; set; }
        //public List<Model> models { get; }
        //public User(string name)
        //{
        //    Name = name;
        //    models = new List<Model>();
        //}
        public override bool Equals(object obj)
        {
            return obj is User user &&
                   Name == user.Name;
            if (user == null)
                return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }
        public override string ToString()
        {
            return Name;
        }

    }
}
