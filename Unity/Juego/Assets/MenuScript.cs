using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
  void Start() {
    SceneManager.LoadScene("SampleScene");
  }
}
