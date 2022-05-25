using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashLightMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            transform.Rotate(-5, 0, 0);
        }
        if (Input.GetKeyDown("down"))
        {
            transform.Rotate(5, 0, 0);
        }
    }
}
