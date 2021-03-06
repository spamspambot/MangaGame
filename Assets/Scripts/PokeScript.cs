﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokeScript : MonoBehaviour
{
    public bool hasFailed;
    public CameraScript camScript;
    public int state;
    public GameObject sfx;
    public SpriteRenderer SR;
    public List<Sprite> sprites;
    SceneScript sceneScript;
   public float clickDelay;
    bool canClick;
    bool hasEnd;
    // Start is called before the first frame update
    void Start()
    {

        canClick = true;
        camScript = Camera.main.GetComponent<CameraScript>();
        sceneScript = Camera.main.GetComponent<SceneScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canClick) { canClick = false; StartCoroutine("ClickDelay"); NextState(); }
        switch (state)
        {
            case 09:
                if (!hasFailed) SR.sprite = sprites[3];
                else SR.sprite = sprites[4]; break;
            case 08: SR.sprite = sprites[2]; break;
            case 07: SR.sprite = sprites[5]; break;
            case 06: SR.sprite = sprites[2]; break;
            case 05: SR.sprite = sprites[0]; break;
            case 04: SR.sprite = sprites[1]; break;
            case 03: SR.sprite = sprites[0]; break;
            case 02: SR.sprite = sprites[0]; break;
            case 01: SR.sprite = sprites[0]; break;
            case 00: SR.sprite = sprites[0]; break;
            default:
                if (!hasFailed) SR.sprite = sprites[3];
                else SR.sprite = sprites[4]; break;
        }
    }

    IEnumerator ClickDelay()
    {
        yield return new WaitForSeconds(clickDelay);
        canClick = true;
    }
    void NextState()
    {
        state++;
        if (state == 4 || state == 6 || state == 8)
            Instantiate(sfx, transform.position, Quaternion.identity);
        if (state < 4 || state > 8)
            camScript.NextCamera();
        if (state >= 9 && !hasEnd) { sceneScript.LoadMainMenu(); hasEnd = true; }

    }
}
