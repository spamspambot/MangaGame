using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public Text text;
    public float timer;
    public static bool hasFailed;
    // Start is called before the first frame update
    void Start()
    {
        hasFailed = false;

    }

    // Update is called once per frame
    void Update()
    {
        text.text = "" + timer;
        timer = timer - Time.deltaTime;
    }
}
