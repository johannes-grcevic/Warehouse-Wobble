using UnityEngine;

public class UVScroll : MonoBehaviour
{
    [SerializeField] private int materialIndex;
    [SerializeField] private float scrollSpeed = 0.5f;

    [SerializeField] private bool scrollX;
    [SerializeField] private bool scrollY;

    [SerializeField] private bool reverse = false;

    void Update()
    {
        float offset = reverse ? Time.time * -scrollSpeed : Time.time * scrollSpeed;

        if (TryGetComponent(out Renderer renderer))
        {
            renderer.materials[materialIndex].mainTextureOffset = new Vector2(scrollX ? offset % 1 : 0, scrollY ? offset % 1 : 0);
        }
    }
}