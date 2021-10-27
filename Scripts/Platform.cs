using UnityEngine;

public class Platform : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<PlayerMovement>();

        if(player != null && collision.attachedRigidbody.velocity.y < 0 && collision.transform.position.y - collision.bounds.size.y / 2 > transform.position.y)
        {
            player.Jump();
        }
    }
}
