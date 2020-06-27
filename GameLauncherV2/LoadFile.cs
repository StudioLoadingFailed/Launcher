using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncherV2
{
    class LoadFile
    {
        public LoadFile(TableLayoutPanel TableGrid)
        {
            string[] lines = File.ReadAllLines(@"D:\Projects\App\GameLauncherV2\GameLauncherV2\Data.txt");
            foreach (var path in lines)
            {
                NewFile file = new NewFile(path, TableGrid);
            }
        }
    }
}
