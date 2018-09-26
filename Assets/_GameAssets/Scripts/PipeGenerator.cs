using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour {

    [SerializeField] Transform prefabTuberia;

	void Start () {
        InvokeRepeating("GeneratePipe", 0, 3);
    }
	
	void Update () {
		
	}

    void GeneratePipe() {
        //Generamos la tubería
        if (GameConfig.IsPlaying()==true)
        {
            Instantiate(prefabTuberia, transform.position + new Vector3(0, -4 + Random.Range(-2f, 2f), 0), Quaternion.identity);
        }
    }
}
