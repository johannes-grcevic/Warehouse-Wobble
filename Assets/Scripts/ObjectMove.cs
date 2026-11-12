using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private Vector3 direction;    

    private void FixedUpdate()
    {
        if (TryGetComponent(out Rigidbody rb))
        {
            rb.Move(transform.position + speed * Time.fixedDeltaTime * direction, Quaternion.identity);
        }
    }
}
