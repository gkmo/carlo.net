﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Carlo.Net
{
    public class Options
    {
        public int? Width { get; set; }

        public int? Height { get; set; }

        public int? Left { get; set; }

        public int? Top { get; set; }

        public string Icon { get; set; }

        public string[] Channel { get; set; }

        public string LocalDataDir { get; set; }

        public Color BgColor { get; set; }
        public string Title { get; set; }
        public object ParamsForReuse { get; set; }
        public IEnumerable<string> Args { get; set; }
        public string UserDataDir { get; set; }
        public string ExecutablePath { get; internal set; }
    }
}
