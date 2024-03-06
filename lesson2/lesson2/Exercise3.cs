using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
     class Exercise3
    {
        Dictionary<string, string> dictionary;

        public Exercise3()
        {
            dictionary = new Dictionary<string, string>()
            {
                ["жарко"] = "hot",
                ["тепло"] = "warm",
                ["холодно"] = "cold",
                ["солнечно"] = "sunny",
                ["облачно"] = "cloudy",
                ["дождь"] = "rain",
                ["снег"] = "snow",
                ["гром"] = "thunder",
                ["мороз"] = "frost",
                ["туман"] = "fog"
            };
        }
        public string Search(string word)
        {
            foreach (var item in dictionary)
            {
                if (item.Key == word)
                {
                    return item.Value;  
                }
            }
            return null;
        }
    }
}
