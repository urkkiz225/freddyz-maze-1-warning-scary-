using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class megisMäärä : MonoBehaviour
{
    public float megisMäärä_=0;
    public GameObject pärinäTeksti;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("megis"))
        {
            megisMäärä_ = megisMäärä_ + 1;
            Destroy(other.gameObject);
            pärinäTeksti.GetComponent<Text>().text = "pärinä leveli: "+megisMäärä_*5f;
        }
    }
}
