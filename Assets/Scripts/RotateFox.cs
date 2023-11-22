using UnityEngine;

public class RotateFox : MonoBehaviour {

    void Start() {
        transform.rotation = Quaternion.Euler(-90f, 90f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
