using UnityEngine;

namespace Asteroids
{
    internal sealed class AccelerationMovePhysics : MovePhysics
    {
        private readonly float _acceleration;
        
        public AccelerationMovePhysics(Rigidbody2D rigidbody2D, float speed, float acceleration): base(rigidbody2D, speed)
        {
            _acceleration = acceleration;
        }

        public void AddAcceleration()
        {
            Speed += _acceleration;
        }

        public void RemoveAcceleration()
        {
            Speed -= _acceleration;
        }
    }
}