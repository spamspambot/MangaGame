using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceWin : MonoBehaviour
{
    SceneScript sceneScript;
    TimerScript timerScript;
    public GameObject startObject;
    bool hasStarted;
    public float dur;
    bool triggered;
    // Start is called before the first frame update
    void Start()
    {

        sceneScript = Camera.main.GetComponent<SceneScript>();
        timerScript = GetComponent<TimerScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (startObject == null && !hasStarted) { hasStarted = true; timerScript.SetTimer(dur); }

        if (transform.childCount <= 0 && !triggered && !TimerScript.hasFailed && !TimerScript.hasWon)
        {
            sceneScript.LoadMainMenu();
            print("Obama");
            triggered = true;
            TimerScript.hasWon = true;  
        }

    }
}
