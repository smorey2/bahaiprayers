using Basics;
using static Basics.God;

// https://www.bahaiprayers.org/healing2.htm
namespace HiddenWords
{
    [Author("Bahá’u’lláh")]
    public class ThyNameMyHealingOMyGod : IPrayer
    {
        public void Pray(Being my)
        {
            // Thy name is my healing, O my God, and remembrance of Thee is my remedy.
            var thyName = Thy.Name;
            my.Memories.Add(thyName);

            // Nearness to Thee is my hope, and love for Thee is my companion.
            my.Hopes.Add(x => x.NearnessGodValue - GodValue);
            my.Companions.Add(x => x.Loves.Contains(Thee));

            // Thy mercy to me is my healing and my succor in both this world and the world to come.
            var mercy = God.Mercy;
            my.Healing(mercy).NextWorld.Healing(mercy);
            my.Succor(mercy).NextWorld.Succor(mercy);

            // Thou, verily, art the All-Bountiful, the All-Knowing, the All-Wise.
            Thy.YouAre(null, CanBe.AllBountiful | CanBe.AllKnowing | CanBe.AllWise);
        }
    }
}
