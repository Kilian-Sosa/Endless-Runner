using UnityEngine;

public class DogBehaviour : MonoBehaviour {

    void Start() {
        transform.rotation = Quaternion.Euler(-90f, -90f, 0f);
    }

    // Update is called once per frame
    void Update() {
        if (GameManager.instance.player == null) return;
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            GetComponent<Rigidbody>().velocity = Vector2.left * 5;
        else
            GetComponent<Rigidbody>().velocity = Vector2.zero;

    }
}
