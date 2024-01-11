﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCaskMod
{
    public class CustomAger
    {
        public string ModUniqueID;
        public string QualifiedItemId;
        public string Name;
        public bool EnableAgingAnywhere;
        public bool EnableMoreThanOneQualityIncrementPerDay;
        public bool EnableAgeEveryObject;
        public float DefaultAgingRate = 1.0f;
        public Dictionary<object, float> AgingData;
        public Dictionary<string, float> AgingDataId = new Dictionary<string, float>();
        public List<string> OverrideMod = new List<string>();
        public List<string> MergeIntoMod = new List<string>();
    }
}
