﻿using GameOrderSimulationDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOrderSimulationDemo.Services
{
    internal interface IGameService
    {
        void Add(Games game);
        void Remove(Games game);    
        void Update(Games game);    

    }
}
