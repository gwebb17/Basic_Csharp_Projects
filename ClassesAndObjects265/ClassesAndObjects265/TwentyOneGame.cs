﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects265
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public override void Play()
        {
            throw new NotImplementedException(); //exception catch
        }

        public override void ListPlayers()
        {
            Console.WriteLine("Welcome to 21, players: ");
            base.ListPlayers();
        }
        public void WalkAway(Player player)   //implemented interface
        {
            throw new NotImplementedException();
        }
    }
}
