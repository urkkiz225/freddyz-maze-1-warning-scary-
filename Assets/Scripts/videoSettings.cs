using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class videoSettings : MonoBehaviour
{
    public int textureQuality=1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            QualitySettings.masterTextureLimit = textureQuality;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            QualitySettings.vSyncCount = 1;
        }
    }

}
