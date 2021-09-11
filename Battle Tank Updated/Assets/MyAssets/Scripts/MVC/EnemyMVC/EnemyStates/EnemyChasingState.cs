﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class handles enemy tank chasing state.
/// </summary>
namespace Outscal.BattleTank3D
{
    public class EnemyChasingState : EnemyState
    {
        public override void OnStateEnter()
        {
            base.OnStateEnter();
            enemyView.activeState = EnemyStatesEnum.Chasing;
            enemyView.enemyController.ChaseToPlayer();
        }

        public override void OnStateExit()
        {
            base.OnStateExit();
        }
    }
}