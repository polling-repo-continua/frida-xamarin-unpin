﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace SampleApp.iOS
{
    class AppleLogger : ILogger
    {
        public void WriteLine(string msg)
        {
            throw new NotImplementedException();
        }
    }
}