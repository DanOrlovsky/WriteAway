﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WriteAway.Core.Domain
{
    public class SiteInformationSettings
    {
        public string DefaultTheme { get; set; }

        public string DisplayEuCookieLawWarning { get; set; }

        public string FacebookLink { get; set; }

        public string TwitterLink { get; set; }

        public string YoutubeLink { get; set; }

        public string GooglePlusLink { get; set; }
    }
}
