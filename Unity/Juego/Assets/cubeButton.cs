using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeButton : MonoBehaviour
{
    public GameObject cubeb;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject test = Instantiate(cubeb, transform.position + (transform.forward * 2), transform.rotation);
            test.transform.localScale = new Vector3(100, 100, 100);
        }
    }
}
