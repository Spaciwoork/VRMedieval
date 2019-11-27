using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
  Animator anim;

  // Start is called before the first frame update
  void Start()
  {
    anim = GetComponent<Animator>();
    Debug.Log("ANIM: " + anim);
  }

  // Update is called once per frame
  void Update()
  {

  }

  void OnTriggerEnter(Collider other)
  {
    Debug.Log("On trigger enter");
    // anim.SetTrigger("OpenDoor");
  }

  void OnTriggerExit(Collider other)
  {
    Debug.Log("On trigger exit");
    // anim.enabled = true;
  }

  void pauseAnimationEvent()
  {
    anim.enabled = false;
  }
}
