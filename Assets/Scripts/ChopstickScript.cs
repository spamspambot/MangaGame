﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChopstickScript : MonoBehaviour
{
    bool isActive;
    public int state;
    public List<Transform> positions;
    public GameObject cross;
    public GameObject circle;
    public FoodScript foodScript;
    public GameObject wrongSfx;
    public GameObject correctSfx;
    public float delay = 1F;
    // Start is called before the first frame update
    void Start()
    {
        isActive = true;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        print("Obama"); if (isActive)
        {
            if (other.CompareTag("Food")) { Instantiate(circle, positions[state].position, Quaternion.identity); state++; StartCoroutine("NextState"); isActive = false; Instantiate(correctSfx, transform.position, Quaternion.identity); }
            else if (other.CompareTag("Blank")) { Instantiate(cross, positions[state].position, Quaternion.identity); state++; StartCoroutine("NextState"); isActive = false; Instantiate(wrongSfx, transform.position, Quaternion.identity); TimerScript.hasFailed = true; }
        }
     
    }

    IEnumerator NextState()
    {

        yield return new WaitForSeconds(delay);
        foodScript.NextState();
        isActive = true;
    }
}
