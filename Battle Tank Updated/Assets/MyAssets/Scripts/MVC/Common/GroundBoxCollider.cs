using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class handles ground box collider.
/// </summary>
namespace Outscal.BattleTank3D
{
    public class GroundBoxCollider : MonoBehaviour
    {
        public static BoxCollider groundboxCollider;
        
        void Awake()
        {
            groundboxCollider = GetComponent<BoxCollider>();
        }
    }
}