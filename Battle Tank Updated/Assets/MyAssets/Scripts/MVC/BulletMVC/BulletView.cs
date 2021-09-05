using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class handles bullet view.
/// </summary>
namespace Outscal.BattleTank3D
{
    public class BulletView : MonoBehaviour
    {
        public BulletController bulletController { get; private set; }
        public ParticleSystem BullectDestroyVFX;
        public GameObject audioSource;
        public float m_MaxLifeTime = 1f;
        public void SetBulletController(BulletController _bulletController)
        {
            bulletController = _bulletController;
        }

        void Start()
        {
            audioSource.transform.parent = null;
            Destroy(audioSource, 0.5f);
            Destroy(gameObject, m_MaxLifeTime);
        }

        private void FixedUpdate()
        {
            bulletController.Movement();
        }

        void OnCollisionEnter(Collision other)
        {
            if ((bulletController.bulletModel.type == BulletTypes.EnemyBullet) && other.gameObject.GetComponent<TankView>() != null)
            {
                TankService.GetInstance().GetTankController().ApplyDamage(bulletController.bulletModel.damage);
            }
            else if ((bulletController.bulletModel.type != BulletTypes.EnemyBullet) && other.gameObject.GetComponent<EnemyView>() != null)
            {

                other.gameObject.GetComponent<EnemyView>().enemyController.ApplyDamage(bulletController.bulletModel.damage);
            }
            DestroyBullets();
        }

        private void DestroyBullets()
        {
            BullectDestroyVFX.transform.parent = null;
            BullectDestroyVFX.Play();
            Destroy(BullectDestroyVFX.gameObject, BullectDestroyVFX.main.duration);
            Destroy(gameObject);
        }
    }
}