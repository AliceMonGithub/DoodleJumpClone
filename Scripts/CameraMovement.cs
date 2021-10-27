using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private void Update()
    {
        if(transform.position.y < _target.position.y)
        {
            transform.position = new Vector3(transform.position.x, _target.position.y, transform.position.z);
        }
    }
}
