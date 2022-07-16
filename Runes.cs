using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Dofus_Fm
{
    public class Runes
    {
        #region Variables
        public string label { get; set; }
        public string category { get; set; }
        public string icon { get; set; }
        public string weight { get; set; }
        
        #endregion

        #region Initialisers
        public Runes() { }
        public Runes(string label, string category, string icon, string weight)
        {
            this.label = label;
            this.category = category;
            this.icon = icon;
            this.weight = weight;
        }
    
        #endregion

        #region Methodes
        static public List<string> getAllCategories()
        {
            List<string> categories = new List<string>();
            int j = 0;
            List<Runes> runes = LoadArrayList();
            for (int i = 0; i < runes.Count; i++)
            {
                if (categories.Contains(runes[i].category))
                {
                    continue;
                }
                categories.Add(runes[i].category);
                j++;
            }
            return categories;
        }
        static public List<Runes> LoadArrayList()
        {
            List<Runes> runes = new List<Runes>();
            JsonConvert.PopulateObject(File.ReadAllText(@"Runes.json").ToString(),runes);
            return runes;
        }

        #endregion
    }
}
