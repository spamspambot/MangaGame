using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceWin : MonoBehaviour
{
    TimerScript timerScript;
    public GameObject startObject;
    bool hasStarted;
    public float dur;
    bool triggered;
    // Start is called before the first frame update
    void Start()
    {
        timerScript = GetComponent<TimerScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (startObject == null && !hasStarted) { hasStarted = true; timerScript.SetTimer(dur); }

        if (transform.childCount <= 0 && !triggered && !TimerScript.hasFailed)
        {
            print("Obama");
            triggered = true;
            TimerScript.hasWon = true;
        }

    }
}
