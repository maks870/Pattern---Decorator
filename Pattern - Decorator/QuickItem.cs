using System;

namespace Pattern___Decorator
{
    class QuickItem : ItemFeature
    {
        private Quality quality = Quality.Rare;
        private Item item;
        public QuickItem(Item item)
        {
            this.item = item;
        }
        public string GetDescription()
        {
            return "Quick " + item.GetDescription();
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
            tempStats.strenght *= 1f;
            tempStats.agility *= 1.5f;
            tempStats.intelligence *= 1f;
            return tempStats;
        }
    }
}
