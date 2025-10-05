using UnityEngine;

namespace __Scripts.hw2
{
    public class MovementController : MonoBehaviour
    {
        [Header("Movement")]
        [SerializeField] private float _speed = 5f;
        [SerializeField] private float _jumpForce = 5f;
        private Vector2 _movement;

        [Header("Ground")]
        [SerializeField] private Transform _groundCheck; 
        [SerializeField] private float _groundCheckRadius = 0.2f;
        [SerializeField] private LayerMask _groundLayer;
        
        [Header("Player")]
        [SerializeField] private GameObject _player;
        
        
        private Rigidbody2D _rigidbody;
        private SpriteRenderer _sprite;
        
        private bool _isGrounded; 
        private bool _isFacingRight = true; 
        
        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            _sprite  = _player.GetComponent<SpriteRenderer>();

        }

        private void Update()
        {
            _movement.x = Input.GetAxis("Horizontal");
            _rigidbody.velocity = new Vector2(_movement.x * _speed, _rigidbody.velocity.y);
            
            _isGrounded = Physics2D.OverlapCircle(_groundCheck.position, _groundCheckRadius, _groundLayer);
            if (Input.GetButtonDown("Jump") && _isGrounded)
            {
                _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _jumpForce);
            }
            
            if (_movement.x > 0 && !_isFacingRight || _movement.x < 0 && _isFacingRight)
            {
                Flip();
            }
        }

        private void Flip()
        {
            _sprite.flipX = _isFacingRight;
            _isFacingRight = !_isFacingRight;
        }
    }
}