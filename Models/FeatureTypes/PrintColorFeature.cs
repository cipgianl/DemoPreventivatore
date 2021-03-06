﻿using DemoPreventivatore.Models.Entities;
using DemoPreventivatore.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoPreventivatore.Models.FeatureTypes
{
    public class PrintColorFeature : BaseFeature
    {
        public PrintColorEnum FrontColor { get; set; }
        public PrintColorEnum RearColor { get; set; }
        public FeatPrintColor[] Options { get; set; }
    }
}
