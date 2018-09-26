using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlasPajaro : MonoBehaviour {

    [SerializeField] float girado = 0;
    [SerializeField] float direccion = 1;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (direccion == 1)
            {
            transform.Rotate(new Vector3(0,0,400) * Time.deltaTime);
            girado += 400;
            if (girado >= 4000) direccion = 2;
            }
        if (direccion == 2) 
            {
            transform.Rotate(new Vector3(0, 0, -400) * Time.deltaTime);
            girado -= 400;
            if (girado <= -4000) direccion = 1;
            }

    }
}
