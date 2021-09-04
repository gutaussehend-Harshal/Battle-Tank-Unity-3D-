﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Outscal.BattleTank3D
{
    public class AchievementModel
    {
        public BulletsFiredAchievementSO bulletsFiredAchievementSO { get; private set; }
        public EnemyKilledAchievementSO enemyKilledAchievementSO { get; private set; }
        
        public AchievementModel(BulletsFiredAchievementSO bulletsFiredSO, EnemyKilledAchievementSO enemyKilledSO)
        {
            this.bulletsFiredAchievementSO = bulletsFiredSO;
            this.enemyKilledAchievementSO = enemyKilledSO;
        }
    }
}