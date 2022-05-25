using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class agentToPlayer : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject playa;
    public Transform agentSelf;
    private bool isPlayerNear;
    private float detectRange=20f;
    private bool playerLight= GameObject.Find("player").GetComponent<Light>().isActiveAndEnabled;


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
        isPlayerNear = Physics.CheckSphere(agentSelf.position,100,100);
        agent.SetDestination(GameObject.Find("player").transform.position);
        if (Vector3.Distance(playa.transform.position, agent.transform.position) > 40 || playa.GetComponent<Light>().isActiveAndEnabled) 
        {  
            
            agent.isStopped = true;
        }
        else if(Vector3.Distance(playa.transform.position, agent.transform.position) < 40 || playa.GetComponent<Light>().isActiveAndEnabled)
        {
            if (!playerLight)
            agent.isStopped = false;
        }
        
    }
}
