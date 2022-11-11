using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    Material MaterialCilindro;

    // Start is called before the first frame update
    void Start()
    {
        MaterialCilindro = GetComponent<Renderer>().material;
        MaterialCilindro.color = Color.yellow;
    }

    private void OnTriggerEnter(Collider other)
    {
        MaterialCilindro.color = Color.red;
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<PlayerMov>().AddScore();
        }

    }
    private void OnTriggerExit(Collider other)
    {
        MaterialCilindro.color = Color.yellow;
    }
}
