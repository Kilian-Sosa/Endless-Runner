using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour {
    public static GameManager instance;
    public GameObject player, enemy;
    public float enemySpeed;
    public float score;

    void Start() {
        instance = this;
        enemySpeed = 5;
    }

    public void Spawn() {
        float positionY = Random.Range((float)-3.5, (float)1.35);
        Vector3 dogPosition = new Vector3(16f, positionY, 0f);
        Instantiate(enemy, dogPosition, Quaternion.Euler(-90, -90, 0));
    }

    public void AddPoint() {
        string scoreString = $"Score: {++score}";
        GameObject.Find("Score").GetComponent<TMP_Text>().text = scoreString;
    }

    public void FinishGame() {
        Destroy(player.gameObject);
    }
}
