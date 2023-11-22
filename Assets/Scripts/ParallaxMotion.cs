using UnityEngine;

public class ParallaxMotion : MonoBehaviour {

    [SerializeField] float parallaxSpeed;
    
    void Update() {
        if (GameManager.instance.player == null) return;
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            GetComponent<SpriteRenderer>().material.mainTextureOffset += Vector2.right * parallaxSpeed * Time.deltaTime;
    }
}
