using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GazeButton : MonoBehaviour
{
  public float sightlength = 100f;
  public GameObject selectedObj;
  public float hoverforwardDistance = .5f;
  [SerializeField] private GameObject bookRecipes;
  public GameObject exitButton;

  void Start () {
  }

  void FixedUpdate()
  {
    RaycastHit seen;
    Ray raydirection = new Ray(transform.position, transform.forward);
    if (Physics.Raycast(raydirection, out seen, sightlength))
    {
      if (seen.collider.tag == "ButtonExit")
      {
        if (selectedObj != null && selectedObj == seen.transform.gameObject)
        {
          exitButton.SetActive(false);
          bookRecipes.SetActive(false);
        }
      }
    }
  }
}
