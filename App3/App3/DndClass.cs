using System;
using System.Collections.Generic;

namespace App3
{
    public class DndClass
    {
        public DndClass()
        {
            
        }

        public DndClass(String name, int points)
        {
            Name = name;
            Points = points;
        }
        
        public String Name { private set; get; }
        
        public int Points { set; get; }

        static DndClass()
        {
            List<DndClass> all = new List<DndClass>
                        {
                            new DndClass("Barbarian",0),
                            new DndClass("Bard",0),
                            new DndClass("Cleric",0),
                            new DndClass("Druid",0),
                            new DndClass("Fighter",0),
                            new DndClass("Monk",0),
                            new DndClass("Rogue",0),
                            new DndClass("Sorcerer", 0),
                            new DndClass("Warlock",0),
                            new DndClass("Wizard",0)
                        };
            All = all;
        }
        public static IList<DndClass> All { set; get; }


    }
}