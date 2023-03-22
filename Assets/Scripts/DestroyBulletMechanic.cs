using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBulletMechanic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag.Contains("Destroy")) {
          Destroy(other.gameObject);
          Destroy(gameObject);
        } else if (other.gameObject.tag.Contains("Transform")) {
          var script = GameObject.FindWithTag("GameController").GetComponent<ConditionManager>();
          script.gameOver = true;
        }
    }
}
