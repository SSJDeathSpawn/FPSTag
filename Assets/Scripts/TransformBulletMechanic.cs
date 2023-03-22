using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformBulletMechanic : MonoBehaviour
{
    public Mesh sphere;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter(Collision other) {
      if (other.gameObject.tag.Contains("Transform")) {
        var mesh_filter = other.gameObject.GetComponent<MeshFilter>();
        mesh_filter.mesh = sphere;
        Debug.Log("Should Sphere");
        other.gameObject.tag = "Sphered";
        Destroy(gameObject);
      } else if (other.gameObject.tag.Contains("Destroy")) {
        var script = GameObject.FindWithTag("GameController").GetComponent<ConditionManager>();
        script.gameOver = true;
      }
    }


}
