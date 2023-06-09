using System;

namespace Pattern___Decorator
{
    class CorruptedItem : ItemFeature
    {
        private Quality quality = Quality.Common;
        private Item item;
        public CorruptedItem(Item item)
        { 
            this.item = item;
        }
        public string GetDescription()
        {
            return "Corrupted " + item.GetDescription();
        }

        public Quality GetQuality()
        {
            double qualityDouble = (((int)item.GetQuality()) + ((int)quality))/2;
            double qualityIndex = Math.Round(qualityDouble, MidpointRounding.AwayFromZero);
            return (Quality)qualityIndex;
        }

        public Stats GetStats()
        {
            Stats stats = item.GetStats();
            Stats tempStats = new Stats(stats.strenght, stats.agility, stats.intelligence);
            tempStats.strenght *= 0.5f;
            tempStats.agility *= 0.5f;
            tempStats.intelligence *= 0.5f;
            return tempStats;
        }
    }
}
