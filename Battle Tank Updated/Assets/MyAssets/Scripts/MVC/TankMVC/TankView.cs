using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class handles player tank view.
/// </summary>
namespace Outscal.BattleTank3D
{
    public class TankView : MonoBehaviour
    {
        private TankController tankController;
        private float movement;
        private float rotation;
        private float canFire = 0f;
        public Transform BulletShootPoint;
        [SerializeField] private MeshRenderer[] childs;
        [SerializeField] private ParticleSystem TankDestroyVFX;

        public void SetTankController(TankController _tankController)
        {
            tankController = _tankController;
        }

        void Update()
        {
            Movement();
            ShootBullet();
        }

        private void FixedUpdate()
        {
            // if (movement != 0)
            // {
            //     tankController.MoveTank(movement, tankController.tankModel.movementSpeed);
            //     // running audio
            //     // SoundManager.Instance.PlayMusic(Sounds.PlayerMove);
            // }
            // else
            // {
            //     // idle audio
            //     // SoundManager.Instance.PlayMusic(Sounds.PlayerIdle);
            // }
            // if (rotation != 0)
            // {
            //     tankController.RotateTank(rotation, tankController.tankModel.rotationSpeed);
            // }

            tankController.MoveTank(movement, tankController.tankModel.movementSpeed);
            tankController.RotateTank(rotation, tankController.tankModel.rotationSpeed);
        }

        private void Movement()
        {
            rotation = Input.GetAxisRaw("Horizontal");
            movement = Input.GetAxisRaw("Vertical");
        }

        private void ShootBullet()
        {
            if (Input.GetMouseButtonDown(0) && canFire < Time.time)
            {
                // SoundManager.Instance.PlayMusic(Sounds.Shoot);
                canFire = tankController.tankModel.fireRate + Time.time;
                tankController.ShootBullet();
            }
        }

        public void DestroyView()
        {
            for (int i = 0; i < childs.Length; i++)
            {
                childs[i] = null;
            }
            tankController = null;
            BulletShootPoint = null;
            TankDestroyVFX.transform.parent = null;
            TankDestroyVFX.Play();
            Destroy(TankDestroyVFX.gameObject, TankDestroyVFX.main.duration + 1f);
            Destroy(this.gameObject);
        }

        // public void TakeDamage(float damage)
        // {
        //     tankController.ApplyDamage(damage);
        // }
    }
}

