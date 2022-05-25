using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class agent : MonoBehaviour
{
    public NavMeshAgent larper;
    public GameObject playa;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        larper.SetDestination(GameObject.Find("player").transform.position);
    }
}
