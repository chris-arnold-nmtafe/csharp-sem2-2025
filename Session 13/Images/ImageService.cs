using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Imported package for working with files

namespace Images
{
    class ImageService
    {
        //Default path to images file - Note the "relative" file path using the ./ string.
        string location = $"./Images/";

        /// <summary>
        /// Gets a list of all of the files names in the Images folder
        /// </summary>
        /// <returns>An array of filenames (with extensions)</returns>
        public string[] GetFiles()
        {
            List<string> fileNames = new List<string>();

            DirectoryInfo info = new DirectoryInfo(location);
            if (info.Exists)
            {
                FileInfo[] infos = info.GetFiles();
                foreach (FileInfo file in infos)
                {
                    fileNames.Add(file.Name);
                }

                return fileNames.ToArray();
            }

            return new string[] { "No Files Found!" };
        }

        /// <summary>
        /// Gets a full path to a file using the file name.
        /// </summary>
        /// <param name="fileName">file name to find.</param>
        /// <returns>The full path to the file name if it exists.</returns>
        public string GetFullString(string fileName)
        {
            DirectoryInfo info = new DirectoryInfo(location);
            if (info.Exists)
            {
                //This is a Linq statement its advanced but uses a kinda of Query language to filter and select items from the list of Files.
                //return info.GetFiles().Where(file => file.Name == fileName).Select(fileInfo => fileInfo.FullName).First();

                //Simple Solution but not as accurate using inbuilt GetFiles search pattern.
                return info.GetFiles(fileName)[0].FullName;
            }
            return ""; //can also return default path to an image for missing
        }

    }
}
