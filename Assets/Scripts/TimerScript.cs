using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public Text text;
    public float timer;
    public static bool hasFailed;
    public static bool hasWon;
    public GameObject correctSound;
    public GameObject failSound;
    // Start is called before the first frame update
    void Start()
    {
        hasWon = false;
        hasFailed = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (!hasFailed && !hasWon)
        {
            text.text = "" + (int)timer;
            timer = timer - Time.deltaTime;
            if (timer <= 0)
            {
                hasFailed = true;
                Instantiate(failSound, transform.position, Quaternion.identity);
            }
        }
    }

    public void SetTimer(float time) {
        timer = time;
        hasFailed = true;
    }
}
