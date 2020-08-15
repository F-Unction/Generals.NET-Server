using System;
using System.Collections.Generic;
using System.Text;
using static Generals.NET_Server.ToolKits;

namespace Generals.NET_Server
{
    interface IMap
    {
        List<List<Block>> Blocks { get; set; }
        MapType Type { get; set; }
        ushort Size { get; set; }

        public void Generate();
        public int GetPlayerBlockNumber(int PlayerID);
        public int GetPlayerTroop(int PlayerID);
    }
}
