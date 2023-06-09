using System;

namespace Pattern___Decorator
{
    class DumbItem : ItemFeature
    {
        private Quality quality = Quality.Rare;
        private Item item;

        public DumbItem(Item item)
        {
            this.item = item;
        }

        public string GetDescription()
        {
            return "Dumb " + item.GetDescription();
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
            tempStats.agility *= 1f;
            tempStats.intelligence *= 0.1f;
            return tempStats;
        }
    }
}
