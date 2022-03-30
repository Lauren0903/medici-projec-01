using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class moving : MonoBehaviour
{
    public GameObject Cube;

    private void OnTriggerEnter(Collider other)
    {
        Cube.transform.parent = transform;
    }

    private void OnTriggerExit(Collider other)
    {
        Cube.transform.parent = null;
    }
}
