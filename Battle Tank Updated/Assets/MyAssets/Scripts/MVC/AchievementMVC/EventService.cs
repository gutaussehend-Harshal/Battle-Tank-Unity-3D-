using System;

/// <summary>
/// This class handles event service.
/// </summary>
namespace Outscal.BattleTank3D
{
    public class EventService : MonoSingletonGeneric<EventService>
    {
        public event Action OnPlayerFiredBullet;
        public event Action OnEnemyKilled;

        public void InvokeOnPlayerFiredBulletEvent()
        {
            OnPlayerFiredBullet?.Invoke();
        }
        public void InvokeOnEnemyKilledEvent()
        {
            OnEnemyKilled?.Invoke();
        }
    }
}