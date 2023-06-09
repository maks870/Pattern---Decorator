namespace Pattern___Decorator
{
    class Armor : Item
    {
        private Quality quality;
        private Stats stats;
        private string description = "Armor";
        public Armor(Stats stats, Quality quality)
        {
            this.stats = stats;
            this.quality = quality;
        }
        public string GetDescription()
        {
            return description;
        }

        public Quality GetQuality()
        {
            return quality;
        }

        public Stats GetStats()
        {
            return stats;
        }
    }
}
