﻿using System.Security.Cryptography.X509Certificates;

namespace SerialLoops.Lib.Script
{
    public class ChessSpaceScriptParameter : ScriptParameter
    {
        public short SpaceIndex { get; set; }

        public ChessSpaceScriptParameter(string name, short spaceIndex) : base(name, ParameterType.CHESS_SPACE)
        {
            SpaceIndex = spaceIndex;
        }

    }
}