using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UNGASpriteSwap : MonoBehaviour
{
    public Sprite sprite;
    public int stateToSwap;
    GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
       if( camera.GetComponent<CameraScript>().state == stateToSwap)
        {
            GetComponent<SpriteRenderer>().sprite = sprite;
        }
    }
}
