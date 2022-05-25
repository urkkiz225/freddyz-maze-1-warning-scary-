using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
    private RaycastHit hit;
    public float raycastDistance;
    public LayerMask interactableLayer;
    public bool keulimassa;
    public GameObject player_;
    public GameObject keulivaObjekti;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit)&&!keulimassa)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (hit.collider.gameObject.CompareTag("keuli"))
                {
                    keulimassa = true;
                    transform.position = keulivaObjekti.transform.position;
                    transform.parent = keulivaObjekti.transform;
                    player_.GetComponent<playerMovement>().enabled = false;
                    player_.GetComponent<CharacterController>().enabled = false;
                    player_.GetComponent<Rigidbody>().isKinematic = true;
                    player_.GetComponent<Collider>().enabled = false;
                }
            }
        }
    }
}
