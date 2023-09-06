namespace PDMSystem
{
    public static class Global
    {
        private static bool onlyCad;
        public static bool OnlyCad
        {
            get
            {
                return onlyCad;
            }
            set
            {
                onlyCad = value;
            }
        }
    }
}
