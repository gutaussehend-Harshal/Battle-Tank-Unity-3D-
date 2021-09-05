using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class handles enemy tank ScriptableObject.
/// </summary>
namespace Outscal.BattleTank3D
{
    [CreateAssetMenu(fileName = "EnemyTankScriptableObjects", menuName = "EnemyScriptableObject/NewEnemy")]
    public class EnemyTankScriptableObject : ScriptableObject
    {
        public EnemyView enemyView;
        public BoxCollider groundArea;

        public float fireRate;
        public BulletScriptableObjects bulletType;

        public float enemyHealth;
    }

    [CreateAssetMenu(fileName = "EnemyTankSO_List", menuName = "EnemyScriptableObjectList/EnemyTankListOfSO")]
    public class EnemyTankScriptableObjectList : ScriptableObject
    {
        public EnemyTankScriptableObject[] enemyTanks;
    }
}