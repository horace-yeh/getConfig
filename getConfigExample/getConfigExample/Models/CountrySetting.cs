using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getConfigExample.Models
{
    public class CountrySetting
    {
        public LangSetting JP { get; set; }
        public LangSetting TW { get; set; }
    }

    public class LangSetting
    {
        public string Lang { get; set; }
        public int TimeZone { get; set; }
    }
}