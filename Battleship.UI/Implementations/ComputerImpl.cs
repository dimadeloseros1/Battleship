﻿using Battleship.UI.Actions;
using Battleship.UI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.UI.Implementations
{
    public class ComputerImpl : IPlayer
    {
        public int MaxNum { get; set; }
        public string Input { get; set; }
        public bool IsHuman { get; private set; } = false;
        public string ChooseCoordinate()
        {
            return "";
        }
    }
}
