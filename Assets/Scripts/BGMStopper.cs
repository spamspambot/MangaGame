using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMStopper : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("BGM").GetComponent<AudioSource>().Stop(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
