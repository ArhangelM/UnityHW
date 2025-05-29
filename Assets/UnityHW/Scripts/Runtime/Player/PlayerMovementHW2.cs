using Assets.UnityHW.Scripts.Common.SignalBus;
using Assets.UnityHW.Scripts.Common.SignalBus.Signals;
using UnityEngine;

namespace Assets.UnityHW.Scripts.Runtime.Player
{
    internal class PlayerMovementHW2 : AdvancedMonoBehaviour
    {
        [SerializeField] private float _jumpPower = 5;
        [SerializeField] private float _speed = 5;
        [SerializeField] private float _groundCheckDistance = 1.1f;
        [SerializeField] private LayerMask _groundMask;

        private bool _isJump;
        private bool _isGrounded;
        private float _xDirection;

        public SpriteRenderer SpriteRenderer => _spriteRenderer;

        private void Awake()
        {
            InitializedComponents();
        }

        private void Update()
        {
            _xDirection = Input.GetAxis("Horizontal");
            if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
            {
                _isJump = true;
            }

            Debug.DrawLine(transform.position, transform.position + Vector3.down * _groundCheckDistance, Color.red);
        }

        private void FixedUpdate()
        {
            Move();

            _isGrounded = Physics2D.Raycast(transform.position, Vector2.down, _groundCheckDistance, _groundMask);
            if (_isJump)
            {
                _rigidbody2D.AddForceY(_jumpPower, ForceMode2D.Impulse);
                _isJump = false;
                SignalBus.Instance.Invoke(new JumpSignal());
            }
        }


        private void Move()
        {
            _rigidbody2D.linearVelocity = new Vector2(_xDirection * _speed, _rigidbody2D.linearVelocity.y);
        }

        private void InitializedComponents()
        {
            GenerateRigidbody2D();
            _rigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation;

            GenerateSpriteRenderer();
            _spriteRenderer.sprite = Resources.Load<Sprite>("Base/Capsule");

            GenerateCapsuleCollider2D();
        }
    }
}
