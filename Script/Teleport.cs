using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject Teleport1;
    bool isJiterring = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!isJiterring)
        {
            Teleport1.GetComponent<Teleport>().isJiterring = true;
            other.transform.position = Teleport1.transform.position;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        isJiterring = false;
    }
}
