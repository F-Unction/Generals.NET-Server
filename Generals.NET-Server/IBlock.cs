using System;
using System.Collections.Generic;
using System.Text;
using static Generals.NET_Server.ToolKits;

namespace Generals.NET_Server
{
    interface IBlock
    {
        BlockType Type { get; set; }
        bool HasOwner { get; set; }
        ushort OwnerID { get; set; }
        uint Troop { get; set; }
    }
}
