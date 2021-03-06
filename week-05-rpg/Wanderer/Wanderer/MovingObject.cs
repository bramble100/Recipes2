﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wanderer
{
    abstract class MovingObject
    {
        protected int XPosition;
        protected int YPosition;
        protected int MaximalHealthPoints;
        protected int CurrentHealthPoints;
        protected int DefendPoints;
        protected int StrikePoints;
        protected int Level;

        protected Dice dice;

        public MovingObject(Dice dice)
        {
            this.dice = dice;
        }

        public MovingObject(int level, Dice dice) : this(dice)
        {
            InitalizeLevel(level);
            InitalizePoints();
        }

        internal abstract void InitalizeLevel(int level);

        internal abstract void InitalizePoints();

        public bool IsAlive
        {
            get
            {
                return CurrentHealthPoints > 0;
            }
        }

        internal void LevelUp()
        {
            // after successfully won battle the character is leveling up
            Level++;
            // his max HP increases by d6
            MaximalHealthPoints += dice.Roll();
            // his DP increases by d6
            DefendPoints += dice.Roll();
            // his SP increases by d6
            StrikePoints += dice.Roll();
        }

        internal void Strike(MovingObject defendant)
        {
            int StrikeValue = StrikePoints + 2 * dice.Roll();
            bool StrikeIsSuccesful = StrikeValue > defendant.DefendPoints;
            if (StrikeIsSuccesful)
            {
                defendant.CurrentHealthPoints -= StrikeValue - defendant.DefendPoints;
                defendant.CurrentHealthPoints = Math.Max(0, defendant.CurrentHealthPoints);
            }
        }

        public override string ToString()
        {
            return $"{GetType().ToString()}" +
                $" (Level: {Level})" +
                $" HP: {CurrentHealthPoints}/{MaximalHealthPoints}" +
                $" | DP: {DefendPoints}" +
                $" | SP: {StrikePoints}";
        }
    }
}
