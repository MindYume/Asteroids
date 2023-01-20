using UnityEngine;

namespace Asteroids
{
    internal class MovePhysics : IMove
    {
        private readonly Rigidbody2D _rigidbody2D;
        private Vector3 _move;
        public float Speed {get; protected set;}

        public MovePhysics(Rigidbody2D rigidbody2D, float speed)
        {
            _rigidbody2D = rigidbody2D;
            Speed = speed;
        }
        
        public void Move(float horizontal, float vertical, float deltaTime)
        {
            var speed = deltaTime * Speed;
            _move.Set(horizontal * speed, vertical * speed, 0.0f);
            _rigidbody2D.AddForce(_move);
        }
    }
}
