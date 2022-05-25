using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headBob : MonoBehaviour
{
    public GameObject playerCam;
    public bool isWpressed;
    public float pingPong;
    public float bobAmount=0.09f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            isWpressed = true;
        }
        else
        {
            isWpressed=false;
        }
    }
    private void FixedUpdate()
    {
        if (pingPong < -0.09f)
        {
            bobAmount = 0.01f;
        }
        if (pingPong > 0.09f)
        {
            bobAmount = -0.01f;
        }
        if (isWpressed)
        {
            playerCam.transform.position = new Vector3(playerCam.transform.position.x, playerCam.transform.position.y + pingPong, playerCam.transform.position.z);
        }
        pingPong = pingPong + bobAmount;

    }
}
