using System;
using System.IO;

namespace Session_8
{
    internal class ContactCSVStorage
    {
        public String FileName { get; set; }
        public ContactCSVStorage(string filename) {
            FileName = filename;
        }

        public void SaveContacts(Contact[] contacts)
        {
            string encodedData = "";
            foreach (Contact contact in contacts)
            {
                encodedData += $"{contact.Name},{contact.Address},{contact.Email}\n";
            }
            File.WriteAllText(FileName, encodedData.Trim());
        }
        public Contact[] ReadContacts()
        {
            string rawData=File.ReadAllText(FileName);
            string[] lines=rawData.Split("\n");
            Contact[] results=new Contact[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(",");
                if (values.Length < 3)
                {
                    continue;
                }
                Contact newContact = new Contact()
                {
                    Name = values[0],
                    Address = values[1],
                    Email = values[2]
                };
                results[i] = newContact;
            }
            return results;
        }
    }
}
