using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextContol : MonoBehaviour
{
    public TMP_Text textObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      var text = string.Format(
          "Red: {0}<br>Blue: {1}", 
          GameObject.FindGameObjectsWithTag("DestroyCube").Length, 
          GameObject.FindGameObjectsWithTag("TransformCube").Length);

      textObj.SetText(text);
    }
}
