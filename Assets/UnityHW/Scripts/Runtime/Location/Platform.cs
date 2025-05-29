using UnityEngine;

namespace Assets.UnityHW.Scripts.Runtime.Location
{
    internal class Platform : AdvancedMonoBehaviour
    {
        public SpriteRenderer SpriteRenderer => _spriteRenderer;
        private void Awake()
        {
            GenerateRigidbody2D();
            _rigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation;
            _rigidbody2D.bodyType = RigidbodyType2D.Static;

            GenerateSpriteRenderer();
            _spriteRenderer.sprite = Resources.Load<Sprite>("Base/Capsule");

            GenerateBoxCollider2D();
            _collider2D.usedByEffector = true;

            gameObject.AddComponent<PlatformEffector2D>();
        }
    }
}
