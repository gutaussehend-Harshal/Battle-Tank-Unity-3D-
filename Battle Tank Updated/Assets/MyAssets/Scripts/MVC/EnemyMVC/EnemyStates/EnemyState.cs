using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class handles enemy tank states.
/// </summary>
namespace Outscal.BattleTank3D
{
    public class EnemyState : MonoBehaviour
    {
        public EnemyView enemyView;

        public virtual void OnStateEnter()
        {
            this.enabled = true;
        }

        public virtual void OnStateExit()
        {
            this.enabled = false;
        }

        public void ChangeState(EnemyState newState)
        {
            if (enemyView.currentState != null)
            {
                enemyView.currentState.OnStateExit();
            }
            enemyView.currentState = newState;
            enemyView.currentState.OnStateEnter();
        }
    }
}