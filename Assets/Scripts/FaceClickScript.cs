﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceClickScript : MonoBehaviour
{
    public GameObject sfx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)) { if (sfx != null) Instantiate(sfx); Destroy(gameObject); }
    }
}
