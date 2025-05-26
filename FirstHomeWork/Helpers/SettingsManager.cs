using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHomeWork
{
    public static class SettingsManager
    {
        public static int Volume { get; set; } = 50;
        public static string PlayerName { get; set; } = null;
        public static bool IsDebugMode { get; set; } = false;
    }
}
