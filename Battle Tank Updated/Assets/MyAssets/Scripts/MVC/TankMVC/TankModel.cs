using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class handles player tank model.
/// </summary>
namespace Outscal.BattleTank3D
{
    public class TankModel
    {
        private TankController tankController;
        public TankType tankType { get; private set; }
        public float movementSpeed { get; private set; }
        public float rotationSpeed { get; private set; }
        public float health { get; set; }
        public BulletScriptableObjects bulletType { get; private set; }
        public float fireRate { get; private set; }
        public int bulletFired { get; set; }
        public int enemyKilled { get; set; }

        public TankModel(TankScriptableObjects tankSO)
        {
            tankType = tankSO.tankType;
            movementSpeed = tankSO.movementSpeed;
            rotationSpeed = tankSO.rotationSpeed;
            health = tankSO.health;
            fireRate = tankSO.fireRate;
            bulletType = tankSO.bulletType;
            bulletFired = 0;
            enemyKilled = 0;
            // bulletFired = PlayerPrefs.GetInt("BulletsFired");
        }

        public void SetTankController(TankController _tankController)
        {
            tankController = _tankController;
        }

        public void DestroyModel()
        {
            bulletType = null;
            tankController = null;
        }
    }
}

