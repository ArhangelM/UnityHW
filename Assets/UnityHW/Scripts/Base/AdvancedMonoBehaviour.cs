using UnityEngine;

public class AdvancedMonoBehaviour : MonoBehaviour
{
    protected Rigidbody2D _rigidbody2D;
    protected SpriteRenderer _spriteRenderer;
    protected Collider2D _collider2D;
    protected void GenerateRigidbody2D()
    {
        _rigidbody2D = gameObject.AddComponent<Rigidbody2D>();
    }
    
    protected void GenerateSpriteRenderer()
    {
        _spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
    } 
    
    protected void GenerateCapsuleCollider2D()
    {
        _collider2D = gameObject.AddComponent<CapsuleCollider2D>();
    } 
    
    protected void GenerateBoxCollider2D()
    {
        _collider2D = gameObject.AddComponent<BoxCollider2D>();
    }
}
