using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keuli : MonoBehaviour
{
    private Animator anim;
    [SerializeField]private Rigidbody rb;
    [SerializeField] private Rigidbody rb_;
    [SerializeField] private float keuliSpeed;
    [SerializeField] private float kääntöNopeus;
    public float speed;
    public GameObject player;
    public GameObject player_;
    private bool keulimassa_;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInParent<Animator>();
        rb = GetComponent<Rigidbody>();
        rb_ = player_.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<raycast>().keulimassa)
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                keulimassa_ = !keulimassa_;
                if (!keulimassa_)
                {
                    anim.Play("keuli");
                }
                else if(keulimassa_)
                {
                    anim.Play("laske");
                }
            }
            if (Input.GetKey(KeyCode.N))
            {
                rb_.AddRelativeForce(0, 0, -speed);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                //rb.AddRelativeTorque(-kääntöNopeus, 0f, 0f);
                rb_.AddTorque(new Vector3(0, -kääntöNopeus,0),ForceMode.Acceleration);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb_.AddTorque(new Vector3(0, kääntöNopeus, 0),ForceMode.Acceleration);
            }
        }
    }

}
