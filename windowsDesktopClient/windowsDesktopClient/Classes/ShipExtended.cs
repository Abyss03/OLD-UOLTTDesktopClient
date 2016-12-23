﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsDesktopClient
{
    /// <summary>
    /// Extended version of the Ship class used for the ship list
    /// </summary>
    public class ShipExtended
    {
        public int Id { get; set; }
        public string ShipName { get; set; }
        public int? Length { get; set; }
        public int? Beam { get; set; }
        public int? Height { get; set; }
        public int? NullMass { get; set; }
        public int? CargoCapacity { get; set; }
        public int? Crew { get; set; }
        public int? PowerPlant { get; set; }
        public int? PowerCount { get; set; }
        public int? Primary { get; set; }
        public int? PCount { get; set; }
        public int? Maneuvering { get; set; }
        public int? ManCount { get; set; }
        public int? Shield { get; set; }
        public int? ShieldCount { get; set; }
        public string RaceEnabled { get; set; }
        public int? Price { get; set; }
        public string Class { get; set; }
        public int? CombatSpeed { get; set; }
        public int? CombatRating { get; set; }
        public int? WaveRank { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
    }
}