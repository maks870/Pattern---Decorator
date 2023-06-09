namespace Pattern___Decorator
{
    class RangeWeapon : Item
    {
        private Quality quality;
        private Stats stats;
        private string description = "Range Weapon";
        public RangeWeapon(Stats stats, Quality quality)
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
