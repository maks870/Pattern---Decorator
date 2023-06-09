namespace Pattern___Decorator
{
    class MeeleWeapon : Item
    {
        private Quality quality;
        private Stats stats;
        private string description = "Meele Weapon";
        public MeeleWeapon(Stats stats , Quality quality)
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
