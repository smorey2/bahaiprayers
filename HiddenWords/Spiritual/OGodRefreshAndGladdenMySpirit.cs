using Basics;
using System.Linq;
using static Basics.God;

namespace HiddenWords
{
    // https://www.bahaiprayers.org/spiritual10.htm
    [Author("‘Abdu’l-Bahá")]
    public class OGodRefreshAndGladdenMySpirit : IPrayer
    {
        public void Pray(Being my)
        {
            OGod1(my);
            OGod2(my);
            OGod3(my);
        }

        // O God!
        void OGod1(Being my)
        {
            // Refresh and gladden my spirit.
            my.Spirit.Refresh();
            my.Spirit.Gladden();

            // Purify my heart.
            my.Heart.Purify();

            // Illumine my powers
            my.Powers.Illumine();

            // I lay all my affairs in Thy hand.
            Thy.Handle(my.Affairs);

            // Thou art my Guide and my Refuge.
            Thy.YouAre(my, CanBe.Guide | CanBe.Refuge);

            // I will no longer be sorrowful and grieved; I will be a happy and joyful being.
            my.Sorrows = null;
            my.Griefs = null;
            my.State |= BeingState.Happy | BeingState.Joyful;
        }

        // O God!
        void OGod2(Being my)
        {
            // I will no longer be full of anxiety, nor will I let trouble harass me.
            my.Anxieties.Clear();
            my.TroubleHandler = null;

            // I will not dwell on the unpleasant things of life.
            my.DwellHandler = things => my.DwellHandler(things?.Where(x => !x.IsUnpleasant));
        }

        // O God!
        void OGod3(Being my)
        {
            // Thou art more friend to me than I am to myself.
            Thy.YouAre(my, CanBe.Friend);

            // I dedicate myself to Thee, O Lord.
            my.Dedication = Thee;
        }
    }
}
