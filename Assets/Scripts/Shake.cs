using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public int panel;
    public float shakeAmount;
    bool hasShaken;
    bool shake;
    Vector3 origin;
    GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera");   
    }

    // Update is called once per frame
    void Update()
    {
        if(camera.GetComponent<CameraScript>().state == panel && hasShaken != true)
        {
            hasShaken = true;
            StartCoroutine(ShakeNOW());
        }
        if(shake == true)
        {
            transform.position = origin + Random.insideUnitSphere * shakeAmount;
        }
        else
        {
            transform.position = origin;
        }
    }
    IEnumerator ShakeNOW()
    {
        shake = true;
        yield return new WaitForSeconds(0.5f);
        shake = false;
    }
}
