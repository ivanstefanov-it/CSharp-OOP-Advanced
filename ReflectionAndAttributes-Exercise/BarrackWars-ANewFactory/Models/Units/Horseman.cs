namespace _03BarracksFactory.Models.Units
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Horseman : Unit
    {
        private const int DefaultHealth = 50;
        private const int DefaultDamage = 10;

        protected Horseman() : base(DefaultHealth, DefaultDamage)
        {
        }
    }
}
