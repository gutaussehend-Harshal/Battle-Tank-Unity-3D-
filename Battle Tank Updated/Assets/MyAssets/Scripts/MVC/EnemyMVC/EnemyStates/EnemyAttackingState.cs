using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Outscal.BattleTank3D
{
    public class EnemyAttackingState : EnemyState
    {
        public override void OnStateEnter()
        {
            base.OnStateEnter();
            enemyView.activeState = EnemyStatesEnum.Attacking;
            enemyView.enemyController.ShootBullet();
        }

        public override void OnStateExit()
        {
            base.OnStateExit();
        }
    }
}