using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class soundIncrease : MonoBehaviour
{
    private AudioSource aSrc;
    public float waitTime_;
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        aSrc = GetComponent<AudioSource>();
        StartCoroutine("IncreaseSound");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  

    public IEnumerator IncreaseSound()
    {
        aSrc.clip = clip;
        aSrc.PlayOneShot(clip);
        yield return new WaitForSeconds(waitTime_);
        StartCoroutine("IncreaseSound");
        aSrc.pitch = Random.Range(0.5f, 2f);
    }
}
