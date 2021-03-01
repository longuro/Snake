using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Snake
{
    public class Params
    {
        private string resourcesFolder;

        public Params()
        {
            var ind = Directory.GetCurrentDirectory().ToString()
                .IndexOf("bin", StringComparison.Ordinal);

            string binFolder =
                Directory.GetCurrentDirectory().ToString().Substring(0, ind)
                    .ToString();

            resourcesFolder = binFolder + "resources\\";
        }

        public string GetResourceFolder()
        {
            return resourcesFolder;
        }
    }
}
