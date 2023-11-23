using UnityEngine;

public class DogBehaviour : MonoBehaviour {

    void Start() {
    }

    // Update is called once per frame
    void Update() {
        if (GameManager.instance.player == null) return;
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            GetComponent<Rigidbody>().velocity = Vector2.left * 5;
        else
            GetComponent<Rigidbody>().velocity = Vector2.zero;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Wall")) {
            Spawn();
            Destroy(gameObject);
        }
    }

    private void OnDestroy() {
        print("aaaaaaaa");
        GameManager.instance.AddPoint();
        //Invoke("Spawn", 0.2f);
    }

    public void Spawn() {
        print("aaaaaaaa");
        float positionY = Random.Range((float)-3.5, (float)1.35);
        Vector3 dogPosition = new Vector3(16f, positionY, 0f);
        Instantiate(gameObject, dogPosition, Quaternion.Euler(-90, -90, 0));
    }
}
