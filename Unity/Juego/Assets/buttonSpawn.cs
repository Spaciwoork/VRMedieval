using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonSpawn : MonoBehaviour
{
    public GameObject ball;

    void Start()
    {
    }

    private void Update()
    {
        
    }

    public void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        GameObject test = Instantiate(ball, transform.position + (transform.forward * 2), transform.rotation);
        test.transform.localScale = new Vector3(100, 100, 100);
    }
}
