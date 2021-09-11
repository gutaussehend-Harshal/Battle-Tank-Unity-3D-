using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Destroy everything after player died.
/// </summary>
namespace Outscal.BattleTank3D
{
    public class DestroyGround : MonoBehaviour
    {
        public GameObject[] military;
        public GameObject[] oilFields;
        public GameObject[] rocks;

        public GameObject completeLevelArt;
        public GameObject lit;

        public static DestroyGround instance;

        void Awake()
        {
            instance = this;
        }

        public async void DestroyMilitary()
        {
            for (int i = 0; i < military.Length; i++)
            {
                await new WaitForSeconds(0.25f);
                Destroy(military[i].gameObject);
                Debug.Log("Called");
                military[i] = null;
            }
            DestroyOilFields();
        }
        
        async void DestroyOilFields()
        {
            for (int i = 0; i < oilFields.Length; i++)
            {

                await new WaitForSeconds(0.25f);
                Destroy(oilFields[i].gameObject);
                Debug.Log("Called");
                oilFields[i] = null;

            }
            DestroyOilRocks();
        }

        async void DestroyOilRocks()
        {
            for (int i = 0; i < rocks.Length; i++)
            {

                await new WaitForSeconds(0.25f);
                Destroy(rocks[i].gameObject);
                Debug.Log("Called");
                rocks[i] = null;
            }
            DestroyCompleteLevelArt();
        }

        async void DestroyCompleteLevelArt()
        {
            Destroy(lit);
            lit = null;

            await new WaitForSeconds(1f);

            Destroy(completeLevelArt);
            completeLevelArt = null;
        }
    }
}
