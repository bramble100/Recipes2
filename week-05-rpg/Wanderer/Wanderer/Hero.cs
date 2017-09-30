﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wanderer
{
    class Hero : MovingObject
    {
        public Hero(int level, Dice dice) : base(dice)
        {
        }

        internal override void InitalizeLevel(int level)
        {
            Level = level;
        }

        internal override void InitalizePoints()
        {
            // HP: 20 + 3 * d6
            MaximalHealthPoints = CurrentHealthPoints = 20 + dice.Roll() + dice.Roll() + dice.Roll();
            // DP: 2 * d6
            DefendPoints = 2 + dice.Roll() + dice.Roll();
            // SP: 5 + d6
            StrikePoints = 5 + dice.Roll();
        }

        internal void EnterNextArea()
        {
            RestorePoints();
        }

        private void RestorePoints()
        {
            int random10 = dice.random.Next(10);
            // when entering a new area the hero has
            // 50 % chance to restore 10 % of his HP
            CurrentHealthPoints += CurrentHealthPoints / 10;
            // 40 % chance to restore the third of his HP
            CurrentHealthPoints += random10 > 4 ? (int)(CurrentHealthPoints * 0.23) : 0;
            // 10 % chance to restore all his HP
            CurrentHealthPoints = random10 > 8 ? CurrentHealthPoints : MaximalHealthPoints;

            // HP cannot exceed the max value
            CurrentHealthPoints = Math.Max(CurrentHealthPoints, MaximalHealthPoints);
        }
    }
}