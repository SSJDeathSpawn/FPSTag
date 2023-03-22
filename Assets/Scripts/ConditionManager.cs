using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionManager : MonoBehaviour
{
    public bool gameOver;
    public GameObject gameOverScreen;
    public GameObject gameWinScreen;
    public GameObject[] removedObjects;
    public MonoBehaviour[] removedScripts;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(gameOver) {
        gameOverScreen.SetActive(true);
        foreach(MonoBehaviour mb in removedScripts) {
          mb.enabled = false;
        }
        foreach(GameObject go in removedObjects) {
          Destroy(go);
        }
      }
      if (noDestroyCube() && noTranformCube()) {
        gameWinScreen.SetActive(true);
        foreach(MonoBehaviour mb in removedScripts) {
          mb.enabled = false;
        }
      }
    }

    bool noTranformCube() {
      return GameObject.FindGameObjectsWithTag("TransformCube").Length == 0;
    }

    bool noDestroyCube() {
      return GameObject.FindGameObjectsWithTag("DestroyCube").Length == 0;
    }
}
