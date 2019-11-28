using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Gaze : MonoBehaviour
{
    public float sightlength = 100f;
    public GameObject selectedObj;
    public float hoverforwardDistance = .5f;
    [SerializeField] private GameObject bookRecipes;

    void Start () {
            bookRecipes.SetActive(false);
    }

    void FixedUpdate()
    {
      RaycastHit seen;
      Ray raydirection = new Ray(transform.position, transform.forward);
      if (Physics.Raycast(raydirection, out seen, sightlength))
      {
        if (seen.collider.tag == "Button")
        {
          if (selectedObj != null && selectedObj == seen.transform.gameObject)
          {
            Debug.Log("EH OH LA");
            bookRecipes.SetActive(true);
          }
        }
      }
    }
}
