using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcController : MonoBehaviour
{
  // movement target
  // public Transform target;

  // int speed
  //

  public PathFollower path;

  // speed target
  // public float speed = 3;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Function to enter in the shop

  // Function to leave the shop

  // Update is called once per frame
  void Update()
  {
    // // calculate the distance from target
    // float distance = Vector3.Distance(transform.position, target.position);

    // // have arrived ?
    // if (distance > 0)
    // {
    //   // calculate how much we need to move (step)
    //   float step = speed * Time.deltaTime;
    //   // move by that step
    //   transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    // }
  }
}
