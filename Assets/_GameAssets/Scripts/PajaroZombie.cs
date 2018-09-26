using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PajaroZombie : MonoBehaviour {

    [SerializeField] Text marcadorPuntos;
    [SerializeField] float fuerza = 80f;
    [SerializeField] ParticleSystem prefabExplosion;
    private int puntos = 0;

    private Rigidbody rb;

    //Aquí estamos determinando en qué consiste la refactorización "ActualizarMarcador()"
    private void ActualizarMarcador()
    {
        marcadorPuntos.text = "Marcador: " + puntos.ToString();
    }


    private void FinalizarPartida()
    {
        //Reiniciar nivel
        Destroy(this.gameObject);
        SceneManager.LoadScene(0);
        GameConfig.ArrancaJuego();
    }

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        ActualizarMarcador();
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            //Reaccionar al presionar espacio
            rb.AddForce(transform.up * fuerza);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Sumar puntos al pasar
        puntos += 1;
        ActualizarMarcador();
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Detener el juego
        GameConfig.ParaJuego();
        //Crear el sistema de partículas
        Instantiate(prefabExplosion, transform.position , Quaternion.identity);
        //Desactivar el pájaro
        gameObject.SetActive(false);
        //Llamar a finalizar la partida a los 3 segundos
        Invoke("FinalizarPartida", 3f);
    }

}
