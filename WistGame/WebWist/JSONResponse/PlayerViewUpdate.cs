﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebWist
{
    [System.Serializable]
    public class PlayerViewUpdate : JSONResponse
    {
        public override string MessageType => "PlayerViewUpdate";

        public WistGame.GameStateID GameStateID;
        public int PlayerIndex;
        public WistGame.Card[] Hand;
        public WistGame.Failures[] BetFailures;
        public int Bet;
        public int PlayedCard;
        public int Score;
        public Player[] OtherPlayers;

        public struct Player
        {
            public int Bet;
            public int NumberOfCards;
            public int CurrentScore;
        }
    }
}
