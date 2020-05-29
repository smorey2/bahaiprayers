using System;
using System.Collections.Generic;

namespace Basics
{
    public class Being
    {
        public BeingSpirit Spirit { get; set; }
        public BeingHeart Heart { get; set; }
        public BeingPower Powers { get; set; }
        public List<object> Sorrows { get; set; } = new List<object>();
        public List<object> Griefs { get; set; } = new List<object>();
        public BeingState State { get; set; }
        public List<object> Anxieties { get; set; } = new List<object>();
        public List<object> Affairs { get; } = new List<object>();
        public object Dedication { get; set; }
        public HashSet<object> Memories { get; } = new HashSet<object>();
        public Being NextWorld { get; } = new Being();
        public float NearnessGodValue { get; set; }

        public Being Healing(object mercy)
        {
            return this;
        }

        public Being Succor(object mercy)
        {
            return this;
        }

        public HashSet<object> Loves { get; } = new HashSet<object>();
        public List<Func<Being, float>> Hopes { get; } = new List<Func<Being, float>>();
        public List<Func<Being, bool>> Companions { get; } = new List<Func<Being, bool>>();

        public Action<IEnumerable<Thing>> TroubleHandler { get; set; }
        public Action<IEnumerable<Thing>> DwellHandler { get; set; }
    }
}
