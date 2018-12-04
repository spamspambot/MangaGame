using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reticle : MonoBehaviour
{
    public GameObject page;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public GameObject gunSFX;
    int clicked = 0;
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
        if (Input.GetMouseButtonDown(0))
        {
            if (clicked == 0) {
                clicked += 1;
            page.GetComponent<SpriteRenderer>().sprite = sprite1;
            }else
            if(clicked == 1)
            {
                clicked += 1;
                page.GetComponent<SpriteRenderer>().sprite = sprite2;
            }else
            if (clicked == 2)
            {
                clicked += 1;
                page.GetComponent<SpriteRenderer>().sprite = sprite3;
            }
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraScript>().NextCamera();


            Instantiate(gunSFX);
        }
    }
}
