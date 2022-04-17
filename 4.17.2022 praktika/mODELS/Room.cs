using System;
using System.Collections.Generic;
using System.Text;

namespace _4._17._2022_praktika.mODELS
{
    class Room
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Personcapacity { get; set; }
        public bool IsAviable { get; set; } = true;
        public Room(string name,double price,int personcapacity)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            Personcapacity = personcapacity;
        }

        public string ShowInfo()
        {
            return $"Id: {Id} - Name: {Name} - Price: {Price} - PersonCapacity: {Personcapacity} - IsAviable: {IsAviable}";
        }



        //public override string ToString()
        //{
        //    return ShowInfo();
        //}

    }
}
