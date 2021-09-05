using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class handles camera controller.
/// </summary>
namespace Outscal.BattleTank3D
{
    public class CameraController : MonoBehaviour
    {
        public Camera cam;
        [SerializeField] private Transform target;
        [SerializeField] private float smoothSpeed = 0.005f;
        [SerializeField] private Vector3 offset = new Vector3(300, 300, 300);
        private Vector3 targetPos;
        private Vector3 desiredposition;
        private Vector3 smoothPosition;
        private Transform playerLastPos;
        public static CameraController instance;

        void Awake()
        {
            instance = this;
        }

        public void SetTarget(Transform target)
        {
            if (target != null)
            {
                this.target = target;
            }
        }

        private void LateUpdate()
        {
            if (target != null)
            {
                desiredposition = target.position + offset;
                playerLastPos = target;
            }
            else
            {
                cam.orthographicSize = 25f;
                target = playerLastPos;
            }
            smoothPosition = Vector3.Lerp(this.transform.position, desiredposition, smoothSpeed);
            transform.position = smoothPosition;
            transform.LookAt(target);
        }
    }
}

