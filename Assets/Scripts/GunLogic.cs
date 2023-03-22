using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunLogic : MonoBehaviour
{
    public GameObject transformBullet;
    public GameObject destroyBullet;
    public float bulletSpeed = 100f;
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Mouse0) != Input.GetKeyDown(KeyCode.Mouse1)) {
        var bulletObj = Instantiate( ((Input.GetKeyDown(KeyCode.Mouse0))?destroyBullet:transformBullet), spawnPoint.position, spawnPoint.rotation);
        bulletObj.GetComponent<Rigidbody>().velocity = bulletSpeed * spawnPoint.forward;
      }
    }
}
