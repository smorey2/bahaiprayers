using System.Collections.Generic;

namespace Basics
{
    public class God
    {
        public static readonly God Thy = new God();
        public static God Thee => Thy;

        public static object Mercy { get; set; }
        public static float GodValue { get; } = float.MaxValue;
        public string Name { get; set; } = "God";

        public void Handle(List<object> affairs)
        {
        }

        public void YouAre(Being my, CanBe canBe)
        {
        }
    }
}
