using System;
using System.Collections.Generic;
using System.Text;

namespace Generals.NET_Server
{
    class Block : IBlock
    {
        public ToolKits.BlockType Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool HasOwner { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ushort OwnerID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public uint Troop { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
