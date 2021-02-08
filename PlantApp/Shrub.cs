using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantApp
{
    //inheritance in action, it inherits from the 
    class Shrub : Plant
    {
        //polymorphism is shown through the use of the override keyword. (make it return another value.)
        /// <summary>
        /// override the Plant Sniff method with a new returned string
        /// </summary>
        /// <returns></returns>
        public override string Sniff()
        {
            
            return "Smells like a shrubbery. Some knights could use this.";
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

        
    }
}
