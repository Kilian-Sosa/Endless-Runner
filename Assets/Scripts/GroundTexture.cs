using UnityEngine;

public class GroundTexture : MonoBehaviour
{
    public float scrollSpeed = 0.5f;
    private Renderer renderer;

    void Start() {
        renderer = GetComponent<Renderer>();
    }

    void Update() {
        float offset = Time.time * scrollSpeed;
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            renderer.material.mainTextureOffset = new Vector2(offset, 0);
    }
}
