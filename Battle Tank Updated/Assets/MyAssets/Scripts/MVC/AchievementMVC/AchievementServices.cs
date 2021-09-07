using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class handles achievement service.
/// </summary>
namespace Outscal.BattleTank3D
{
    public class AchievementServices : MonoSingletonGeneric<AchievementServices>
    {
        [SerializeField] private BulletsFiredAchievementSO bulletsFiredSO;
        [SerializeField] private EnemyKilledAchievementSO enemyKilledSO;
        private AchievementController achievementController;
        private AchievementModel achievementModel;

        void Start()
        {
            CreatAchievement();
        }

        private void CreatAchievement()
        {
            achievementModel = new AchievementModel(bulletsFiredSO, enemyKilledSO);
            achievementController = new AchievementController(achievementModel);
        }

        public AchievementController GetAchievementController()
        {
            return achievementController;
        }
    }
}