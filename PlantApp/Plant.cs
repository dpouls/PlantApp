using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantApp
{
    public abstract class Plant
    {
        //backing fields that are associated with our property
        private string _name;
        private string _environment;
        //property
        public string Environment //property name
        {
            //get accessor, allows for reading
            get { return _environment; }
            //set accessor, allows for writing
            set { _environment = value; }
        }
        //property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Plant()
        {
            Name = "Default Plant Name";
            Environment = "Default plant environment";
            
        }
        public Plant(string paramName, string paramEnvironment)
        {
            Name = paramName;
            Environment = paramEnvironment;
        }
        //abstract means this method must be implemented in derived classes.
        public abstract string Sniff();

        //vitual means we have the option to implement the method in a derived class
        public virtual string Pick()
        {
            return "Default Plant Pick";
        }
    }
}
