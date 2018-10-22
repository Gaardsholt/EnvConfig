using Serilog;
using System;
using System.Diagnostics;
using System.Linq;

namespace EnvConfig
{
    public class EnvSettings
    {
        public EnvSettings() => PopulateProperties();
        public EnvSettings(string prefix) => PopulateProperties(Prefix: prefix);
        public EnvSettings(bool Capitalize) => PopulateProperties(Capitalize: Capitalize);
        public EnvSettings(string prefix = "", bool? Capitalize = true) => PopulateProperties(Prefix: prefix, Capitalize: Capitalize);


        private void PopulateProperties(string Prefix = "", bool? Capitalize = true)
        {
            if (!string.IsNullOrWhiteSpace(Prefix))
                Prefix += "_";

            foreach (var prop in this.GetType().GetProperties())
            {
                var envName = $"{Prefix}{prop.Name}";
                envName = Capitalize.Value ? envName.ToUpper() : envName;

                prop.SetValue(this, Environment.GetEnvironmentVariable(envName));
            }


            var missing = this.GetType().GetProperties().Where(a => string.IsNullOrEmpty(a.GetValue(this)?.ToString())).Select(b => b.Name);
            
            //var all = this.GetType().GetProperties().Select(b => b.Name);
            //Console.WriteLine($"This is all environmental variables: { string.Join(",", all.ToArray()) }");

            if (missing.Count() > 0)
            {
                var errorMsg = $"You are missing the following environmental variables: { string.Join(",", missing.ToArray()) }";

                Log.Error(errorMsg);
                Debug.WriteLine(errorMsg);

                Environment.Exit(1);
            }
        }
    }
}
