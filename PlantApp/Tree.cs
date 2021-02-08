using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantApp
{
    class Tree : Plant
    {
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }/// <summary>
        /// extra method that returns a string about punching trees?
        /// </summary>
        /// <returns></returns>
        public string Chop()
        {
            return "You can only punch trees in video games.";
        }
        /// <summary>
        /// override the Plant Sniff method with a new returned string
        /// </summary>
        /// <returns></returns>
        public override string Sniff()
        {
            return "Why am I sniffing a tree?";

        }
        /// <summary>
        /// override the Plant Pick method with a new returned string
        /// 
        /// </summary>
        /// <returns></returns>
        public override string Pick()
        {
            return "A tree is too heavy to pick";
        }
        /// <summary>
        /// constructor that uses the Plant constructor for name and environment then adds on Age
        /// </summary>
        /// <param name="name"></param>
        /// <param name="environment"></param>
        /// <param name="age"></param>
        public Tree(string name, string environment, int age) : base(name, environment)
        {
            Age = age;
        }
    }
}
