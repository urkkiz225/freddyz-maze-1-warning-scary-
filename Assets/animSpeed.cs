using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class animSpeed : MonoBehaviour
{
    private Animator anim;
    public GameObject player;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.x > 0.01f||rb.velocity.z > 0.01f)
        {
            anim.enabled = true;
            if (player.GetComponent<playerMovement>().isRunning) anim.speed = 2.5f;
            else anim.speed = 1.5f;
        }
        else anim.speed = 0f;
    }
}
