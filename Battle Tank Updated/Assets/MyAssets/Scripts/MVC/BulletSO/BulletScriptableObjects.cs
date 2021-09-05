using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class handles bullet scriptable objects.
/// </summary>
namespace Outscal.BattleTank3D
{
    [CreateAssetMenu(fileName = "BulletScriptableObjects", menuName = "ScriptableObject/NewBullet")]
    public class BulletScriptableObjects : ScriptableObject
    {
        public BulletView bulletView;

        public BulletTypes bulletTypes;
        public float bulletForce;
        public float bulletDamage;
    }

    [CreateAssetMenu(fileName = "BulletSO_List", menuName = "ScriptableObjectList/BulletListOfSO")]
    public class BulletSO_List : ScriptableObject
    {
        public BulletScriptableObjects[] bullets;
    }
}
