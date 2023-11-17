using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField] float jumpForce;
    private Rigidbody rb;

    private void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void Update() {
        if (Input.GetButtonDown("Jump")) rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }
}
