namespace SingletonImplementation
{
    public class ConfigurableRecordFinder
    {
        public IDatabase database;

        public ConfigurableRecordFinder(IDatabase database)
        {
            this.database = database;
        }

        public int GetTotalPopulation(IEnumerable<string> names)
        {
            int result = 0;

            foreach (var name in names)
            {
                result += database.GetPopulation(name);
            }

            return result;
        }
    }
}
