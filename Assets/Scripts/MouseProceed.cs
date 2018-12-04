using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseProceed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraScript>().moving != true) {
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraScript>().NextCamera();
        }
        }
    }
}
