using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class handles enemy tank model.
/// </summary>
namespace Outscal.BattleTank3D
{
    public class EnemyModel
    {
        private EnemyController enemyController;
        public float enemyHealth { get; set; }
        public float fireRate { get; set; }
        public BulletScriptableObjects bulletType { get; private set; }
        [SerializeField] private BoxCollider groundArea;

        public EnemyModel(EnemyTankScriptableObject enemySO)
        {
            // Debug.Log("Enemy model created");
            enemyHealth = enemySO.enemyHealth;
            groundArea = enemySO.groundArea;
            fireRate = enemySO.fireRate;
            bulletType = enemySO.bulletType;
        }

        public void SetEnemyTankController(EnemyController _enemyController)
        {
            enemyController = _enemyController;
        }
        
        // public void SetEnemyTankController(EnemyController _enemyController)
        // {
        //     enemyController = _enemyController;
        // }

        public void DestroyModel()
        {
            // Debug.Log("Destroy Enemy model called");
            bulletType = null;
            enemyController = null;
        }
    }
}