﻿using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AntDesign.Charts
{
    public partial class Temp<TItem> : ChartComponentBase<TItem, BarConfig>
    {
        public Temp() : base("Temp")
        {

        }
    }
}
