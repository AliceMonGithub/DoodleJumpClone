using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadPoint : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private void Update()
    {
        if(_target.position.y <= transform.position.y)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
