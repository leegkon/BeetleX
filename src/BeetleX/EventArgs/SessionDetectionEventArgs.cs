﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeetleX.EventArgs
{
    public class SessionDetectionEventArgs : ServerEventArgs
    {
        public IList<IDetectorItem> Sesions
        {
            get;
            internal set;
        }
    }
}
