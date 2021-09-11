using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// MonoSingletonGeneric class
/// </summary>
namespace Outscal.BattleTank3D
{
    public class MonoSingletonGeneric<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T instance;
        private static object m_lock = new Object();

        public static T GetInstance()
        {
            lock (m_lock)
            {
                if (instance == null)
                {
                    instance = FindObjectOfType<T>();

                    if (instance == null)
                    {
                        GameObject obj = new GameObject();

                        obj.name = typeof(T).ToString();

                        instance = obj.AddComponent<T>();

                        DontDestroyOnLoad(obj);
                    }
                }
            }
            return instance;
        }
    }
}