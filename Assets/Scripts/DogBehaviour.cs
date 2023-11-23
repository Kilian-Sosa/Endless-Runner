using UnityEngine;

public class DogBehaviour : MonoBehaviour {


    // Update is called once per frame
    void Update() {
        if (GameManager.instance.player == null) return;
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            GetComponent<Rigidbody>().velocity = Vector2.left * GameManager.instance.enemySpeed;
        else GetComponent<Rigidbody>().velocity = Vector2.zero;
    }
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Ground")) return;
        if (other.CompareTag("Player") && other.transform.position.y <= transform.position.y) 
            GameManager.instance.Invoke("FinishGame", 0);
        else {
            Spawn();
            Destroy(gameObject);
        }
    }

    private void OnDestroy() {
        if (GameManager.instance.enemySpeed < 16f && (GameManager.instance.score + 1) % 5 == 0)
            GameManager.instance.enemySpeed *= 1.2f;
        GameManager.instance.AddPoint();
    }

    public void Spawn() {
        float positionY = Random.Range((float)-3.5, (float)1.35);
        Vector3 dogPosition = new Vector3(16f, positionY, 0f);
        Instantiate(gameObject, dogPosition, Quaternion.Euler(-90, -90, 0));
    }
}
