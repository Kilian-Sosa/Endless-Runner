using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField] float jumpForce;
    private Rigidbody rb;
    private bool isJumping;

    private void Start() {
        rb = GetComponent<Rigidbody>();
        isJumping = false;
    }

    void Update() {
        if (Input.GetButtonDown("Jump") && !isJumping) {
            rb.AddForce(transform.forward * jumpForce, ForceMode.Impulse); //transform.forward because the model is rotated
            isJumping = true;
        }
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Ground")) isJumping = false;
        if (collision.gameObject.CompareTag("Enemy")) {
            foreach (ContactPoint contact in collision.contacts) {
                if (contact.normal.y > 0.8f) GameManager.instance.Invoke("AddPoint", 2);
                else GameManager.instance.Invoke("FinishGame", 0);
            }
        }
    }
}
