using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodFail : MonoBehaviour
{
    public GameObject failObject;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (TimerScript.hasWon) failObject.SetActive(false);
    }
}
