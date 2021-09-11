using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Tank ScriptableObject class
/// </summary>
namespace Outscal.BattleTank3D
{
    [CreateAssetMenu(fileName = "TankScriptableObjects", menuName = "ScriptableObject/NewTank")]
    public class TankScriptableObjects : ScriptableObject
    {
        public TankType tankType;
        public TankView tankView;
        public float movementSpeed;
        public float rotationSpeed;
        public float health;
        public float fireRate;
        public BulletScriptableObjects bulletType;
    }

    [CreateAssetMenu(fileName = "TankSO_List", menuName = "ScriptableObjectList/TankListOfSO")]
    public class TankScriptableObjectList : ScriptableObject
    {
        public TankScriptableObjects[] tanks;
    }
}