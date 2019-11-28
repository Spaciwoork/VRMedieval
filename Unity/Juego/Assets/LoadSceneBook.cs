using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadSceneBook : MonoBehaviour
{
  private GameObject sceneController;

  private bool isLookedAt = false;

  public float timerDuration = 3f;

  private float lookTimer = 0f;

  private GameObject gazeTimer;

  void Start () {
      sceneController = GameObject.Find("SceneController");
      gazeTimer = GameObject.Find("GazeTimer");
  }

  void Update () {
      if (isLookedAt) {

          lookTimer += Time.deltaTime;

          gazeTimer.GetComponent<Renderer>().material.SetFloat("_Cutoff", lookTimer / timerDuration);

          if (lookTimer > timerDuration) {
              lookTimer = 0f;

              Debug.Log("Button selected!");
              GetComponent<Button>().onClick.Invoke();
          }
      }
      else {
          lookTimer = 0f;
          gazeTimer.GetComponent<Renderer>().material.SetFloat("_Cutoff", 0f);
      }
  }

  public void SetGazedAt(bool gazedAt) {
      isLookedAt = gazedAt;
  }

  public void LoadNextScene() {
      sceneController.GetComponent<SceneController>().LoadNextScene();
  }

  public void LoadPrevScene() {
      sceneController.GetComponent<SceneController>().LoadPrevScene();
  }
}
