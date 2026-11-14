using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class DragAndDrop : MonoBehaviour
{
    [SerializeField] private string snapTag = "";
    [SerializeField] private float snapXOffset = 1.5f;
    [SerializeField] private AudioClip impactSound;

    private Camera mainCam;
    private Rigidbody rb;
    private Vector3 mouseFirstClickScreenPos;
    private bool isDragging = false;

    private void Awake()
    {
        mainCam = Camera.main;
        rb = GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        if (TryGetComponent(out ObjectMove move))
        {
            move.enabled = false;
        }

        mouseFirstClickScreenPos = Input.mousePosition - mainCam.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDrag()
    {
        //Debug.DrawRay(transform.position, Vector3.right, Color.red);
        rb.Move(GetSnapPosition(snapTag, Vector3.right), Quaternion.identity);
        isDragging = true;
    }

    private void OnMouseUp()
    {
        rb.Move(GetSnapPosition(snapTag, Vector3.right), Quaternion.identity);
        isDragging = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (isDragging && !collision.transform.CompareTag(snapTag))
        {
            AudioSource.PlayClipAtPoint(impactSound, transform.position);
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        return mainCam.ScreenToWorldPoint(Input.mousePosition - mouseFirstClickScreenPos);
    }

    private bool IsFacing(string tag, Vector3 direction, out RaycastHit hitInfo)
    {
        return Physics.Raycast(transform.position, direction, out hitInfo) && hitInfo.transform.CompareTag(tag);
    }

    private Vector3 GetSnapPosition(string tag, Vector3 direction)
    {
        return new(IsFacing(tag, direction, out RaycastHit hitInfo) ? hitInfo.transform.position.x - snapXOffset : GetMouseWorldPosition().x, GetMouseWorldPosition().y, GetMouseWorldPosition().z);
    }
}
