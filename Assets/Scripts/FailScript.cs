using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailScript : MonoBehaviour
{
    public Sprite failSprite;
    SpriteRenderer SR;
    // Start is called before the first frame update
    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerScript.hasFailed) { SR.sprite = failSprite; SR.sortingOrder = 10; }
    }
}
