using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [Header("Settings")]

    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _jumpForce;

    [Header("Components")]

    [SerializeField] private Rigidbody2D _rigitbody;

    [SerializeField] private bool _lookRight;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        _rigitbody.velocity = new Vector2(Input.acceleration.x * _moveSpeed, _rigitbody.velocity.y);

        CheckFlip();
    }

    public void Jump()
    {
        _rigitbody.velocity = new Vector2(_rigitbody.velocity.x, _jumpForce);
    }

    private void CheckFlip()
    {
        if(Input.acceleration.x > 0 && !_lookRight)
        {
            Flip();
        }
        else if(Input.acceleration.x < 0 && _lookRight)
        {
            Flip();
        }
    }

    private void Flip()
    {
        transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);

        _lookRight = !_lookRight;
    }
}
