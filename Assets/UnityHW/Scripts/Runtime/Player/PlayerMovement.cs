using UnityEngine;

namespace Assets.UnityHW.Scripts.Runtime.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;

        private void Update()
        {
            Move();
        }

        private void OnCollisionEnter(Collision collision)
        {
            if(collision.collider.CompareTag("Enemy"))
            {
                Debug.Log("Boom!");
            }
        }

        private void Move()
        {
            float xDirection = Input.GetAxis("Horizontal");
            _rigidbody.linearVelocity = new Vector3(xDirection, _rigidbody.linearVelocity.y, _rigidbody.linearVelocity.z);
        }

        public void SetRigidbody(Rigidbody rigidbody) => _rigidbody = rigidbody;
    }
}