using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces{
    public interface ILogger{
        void LogError(string message);
        void LogInfo(string message);
    }
}
