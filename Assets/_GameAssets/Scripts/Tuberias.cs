using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuberias : MonoBehaviour {

    [SerializeField]int speed = 4;

	void Start () {
    }

    void Update() {
        if (GameConfig.IsPlaying() == true)
        {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
        if (transform.position.z < -10)
            {
            Destroy(this.gameObject);
            }
        }
    }
}
