using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantApp
{
    class Flower : Plant
    {
        //polymorphism is shown through the use of the override keyword. (make it return another value.)
        /// <summary>
        /// override the Plant Sniff method with a new returned string
        /// 
        /// </summary>
        /// <returns></returns>
        public override string Sniff()
        {
            return "Smells like bonbon";
        }
        /// <summary>
        /// override the Plant Pick method with a new returned string
        /// 
        /// </summary>
        /// <returns></returns>
        public override string Pick()
        {
            return "Why do roses have thorns?";
        }
        /// <summary>
        /// Constructor method that assigns the name and environment default string values
        /// </summary>
        public Flower()
        {
            Name = "default flower name";
            Environment = "Default flower environment";
        }
        /// <summary>
        /// constructor method that assigns the name and environment variables based on passed parameters.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="environment"></param>
        public Flower(string name, string environment)
        {
            Name = name + "!";
            Environment = environment + "!";
        }
    }
}
