using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            Application.LoadLevel(Application.loadedLevel); 
        }
        if (Input.GetKeyDown("i"))
        {
            Application.LoadLevel(Application.loadedLevel + 1);
            SceneManager.LoadScene("SampleScene");
        }
    }
}
