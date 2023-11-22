using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour {
    public static GameManager instance;
    public GameObject player, enemy;
    [SerializeField] float enemySpeed;

    void Start() {
        instance = this;
        Instantiate(player, new Vector3(-6f, -3.5f), Quaternion.identity);
        SpawnEnemy();
    }

    void Update() {
        if (player == null) return;
        if (enemy.transform.position.x < (player.transform.position.x - 3)) AddPoint();

        //if
        //if (ball.transform.position.x > rightBarrier.transform.position.x) {
        //    score1++;
        //    GameObject.Find("Score1").GetComponent<TMP_Text>().text = score1.ToString();
        //    SpawnBall();
        //} else if (ball.transform.position.x < leftBarrier.transform.position.x) {
        //    score2++;
        //    GameObject.Find("Score2").GetComponent<TMP_Text>().text = score2.ToString();
        //    SpawnBall();
        //}
    }

    private void SpawnEnemy() {
        float positionY = Random.Range((float)-3.5, (float)1.35);
        Vector3 dogPosition = new Vector3(16f, positionY, 0f);
        Instantiate(enemy, dogPosition, Quaternion.identity);
    }

    public void AddPoint() {
        Destroy(enemy);
        // Increase score
        SpawnEnemy();
    }

    public void FinishGame() {
        Destroy(player);
    }
}
