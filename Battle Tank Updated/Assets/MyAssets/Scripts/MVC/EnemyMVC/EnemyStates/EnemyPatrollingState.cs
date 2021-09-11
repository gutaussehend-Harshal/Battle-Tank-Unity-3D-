using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class handles enemy tank patrolling state.
/// </summary>
namespace Outscal.BattleTank3D
{
    public class EnemyPatrollingState : EnemyState
    {
        public override void OnStateEnter()
        {
            base.OnStateEnter();
            enemyView.activeState = EnemyStatesEnum.Patrolling;
            enemyView.enemyController.Patrol();
        }

        public override void OnStateExit()
        {
            base.OnStateExit();
        }
    }
}