using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Material MaterialCilindro;
    public Publisher Notificador;
    public int Force = 500;
    // Start is called before the first frame update
    void Start()
    {
        //Notificador.CustomEvent += MoveObjectsFn;

        MaterialCilindro = GetComponent<Renderer>().material;
        MaterialCilindro.color = Color.magenta;
        Notificador.TouchEvent += MoveObjectsFn;

    }

    private void OnTriggerEnter(Collider other)
    {
        MaterialCilindro.color = Color.red;
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<PlayerMov>().HealthUpdate();
        }
        //GetComponent<Rigidbody>().AddForce(0, Force, Force);
    }
    private void OnTriggerExit(Collider other)
    {
        MaterialCilindro.color = Color.magenta;
    }
    void MoveObjectsFn()
    {
        GetComponent<Rigidbody>().AddForce(0, Force, Force);
    }
}
