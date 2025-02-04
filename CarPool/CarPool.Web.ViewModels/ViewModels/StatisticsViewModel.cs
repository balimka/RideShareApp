﻿using CarPool.Services.Mapping.DTOs;
using System;
using System.Collections.Generic;

namespace CarPool.Web.ViewModels.DTOs
{
    public class StatisticsViewModel
    {
        public StatisticsViewModel()
        {
            var r = new Random();

            AchievementsCount = r.Next(10, 30);
        }

        public List<TopUserDTO> TopUsers { get; set; }

        public int UsersCount { get; set; }

        public int TripsCount { get; set; }

        public int AchievementsCount { get; private set; }
    }
}
