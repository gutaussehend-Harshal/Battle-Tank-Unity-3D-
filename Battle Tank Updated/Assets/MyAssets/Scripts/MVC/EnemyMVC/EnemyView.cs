using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// This class handles enemy tank view.
/// </summary>
namespace Outscal.BattleTank3D
{
    public class EnemyView : MonoBehaviour
    {
        [SerializeField] private ParticleSystem TankDestroyVFX;
        public NavMeshAgent enemyNavMesh;
        public EnemyController enemyController;
        [SerializeField] private BoxCollider ground;
        public float maxX, maxZ, minX, minZ;
        public float timer, patrolTime;
        public float howClose;
        public float canFire = 0f;
        public Transform BulletShootPoint;
        public Transform playerTransform;
        [SerializeField] private MeshRenderer[] childs;
        public EnemyPatrollingState patrollingState;
        public EnemyChasingState chasingState;
        public EnemyAttackingState attackingState;
        public EnemyStatesEnum initialState;
        public EnemyStatesEnum activeState;
        public EnemyState currentState;

        void Awake()
        {
            enemyNavMesh = gameObject.GetComponent<NavMeshAgent>();
        }

        void Start()
        {
            currentState = patrollingState;
            InitializeState();
            SetGroundForEnemyPatrolling();
            setPlayerTransform();
            timer = 5f;
            patrolTime = 2f;
            howClose = 15f;
        }

        public void SetEnemyTankController(EnemyController _enemyController)
        {
            enemyController = _enemyController;
        }

        private void setPlayerTransform()
        {
            playerTransform = TankService.GetInstance().PlayerPos();
        }

        private void SetGroundForEnemyPatrolling()
        {
            ground = GroundBoxCollider.groundboxCollider;
            maxX = ground.bounds.max.x;
            maxZ = ground.bounds.max.z;
            minX = ground.bounds.min.x;
            minZ = ground.bounds.min.z;
        }

        void Update()
        {
            enemyController.EnemyPatrollingAI();
        }

        private void InitializeState()
        {
            switch (initialState)
            {
                case EnemyStatesEnum.Attacking:
                    currentState = attackingState;
                    break;

                case EnemyStatesEnum.Chasing:
                    currentState = chasingState;
                    break;

                case EnemyStatesEnum.Patrolling:
                    currentState = patrollingState;
                    break;

                default:
                    currentState = null;
                    break;
            }
            currentState.OnStateEnter();
        }

        public void DestroyView()
        {
            for (int i = 0; i < childs.Length; i++)
            {
                childs[i] = null;
            }

            BulletShootPoint = null;
            enemyNavMesh = null;
            ground = null;
            playerTransform = null;
            TankDestroyVFX.transform.parent = null;
            TankDestroyVFX.Play();
            Destroy(TankDestroyVFX.gameObject, TankDestroyVFX.main.duration + 1f);
            Destroy(this.gameObject);
        }
    }
}