using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class antiFall : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.y<-20)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
