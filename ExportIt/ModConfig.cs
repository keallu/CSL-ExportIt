namespace ExportIt
{
    [ConfigurationPath("ExportItConfig.xml")]
    public class ModConfig
    {
        public bool ConfigUpdated { get; set; }

        private static ModConfig instance;

        public static ModConfig Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = Configuration<ModConfig>.Load();
                }

                return instance;
            }
        }

        public void Save()
        {
            Configuration<ModConfig>.Save();
            ConfigUpdated = true;
        }
    }
}