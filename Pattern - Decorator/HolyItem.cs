using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern___Decorator
{
    class HolyItem : ItemFeature
    {
        private Quality quality = Quality.Legendary;
        private Item item;

        public HolyItem(Item item)
        {
            this.item = item;
        }

        public string GetDescription()
        {
            return "Holy " + item.GetDescription();
        }

        public Quality GetQuality()
        {
            double qualityDouble = (((int)item.GetQuality()) + ((int)quality)) / 2;
            double qualityIndex = Math.Round(qualityDouble, MidpointRounding.AwayFromZero);
            return (Quality)qualityIndex;
        }

        public Stats GetStats()
        {
            Stats stats = item.GetStats();
            Stats tempStats = new Stats(stats.strenght, stats.agility, stats.intelligence);
            tempStats.strenght *= 2f;
            tempStats.agility *= 2f;
            tempStats.intelligence *= 2f;
            return tempStats;
        }
    }
}
