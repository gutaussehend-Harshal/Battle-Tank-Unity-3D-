using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class handles bullet model.
/// </summary>
namespace Outscal.BattleTank3D
{
    public class BulletModel
    {
        public float bulletForce { get; private set; }
        public float damage { get; private set; }
        public BulletTypes type;
        private BulletController bulletController;

        public BulletModel(BulletScriptableObjects bulletSO)
        {
            bulletForce = bulletSO.bulletForce;
            damage = bulletSO.bulletDamage;
            type = bulletSO.bulletTypes;
        }

        public void SetBulletController(BulletController _bulletController)
        {
            bulletController = _bulletController;
        }
        // public void SetBulletController(BulletController _bulletController)
        // {
        //     bulletController = _bulletController;
        // }
    }
}