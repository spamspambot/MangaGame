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
    public static bool hasStarted;

    public GameObject correctSound;
    public GameObject failSound;

    // Start is called before the first frame update
    void Start()
    {
         hasWon = false;
         hasFailed = false;
         hasStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (hasFailed) text.gameObject.SetActive(false);

        if (!hasFailed && !hasWon && hasStarted)
        {
            timer = timer - Time.deltaTime;
            text.text = "" + (int)timer;
          
            if (timer <= 0)
            {
                print("IsThisLoss");
                hasFailed = true;
                Instantiate(failSound, transform.position, Quaternion.identity);
            }
        }
    }

    public void SetTimer(float time)
    {
        text.gameObject.SetActive(true);
        hasStarted = true;
        hasFailed = false;
        timer = time;
    }
}
