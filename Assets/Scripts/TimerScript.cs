using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    SceneScript sceneScript;

    public Text text;
    public float timer;
    public static bool hasFailed;
    public static bool hasWon;
    public static bool hasStarted;

    public GameObject correctSound;
    public GameObject failSound;
    bool wonOnce;
    // Start is called before the first frame update
    void Start()
    {
        sceneScript = Camera.main.GetComponent<SceneScript>();
        hasWon = false;
        hasFailed = false;
        hasStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (hasFailed || hasWon) text.gameObject.SetActive(false);
        if (hasWon && !wonOnce) { wonOnce = true; Instantiate(correctSound, transform.position, Quaternion.identity); }
        if (!hasFailed && !hasWon && hasStarted)
        {
            timer = timer - Time.deltaTime;
            text.text = "" + (int)timer;

            if (timer <= 0 && !hasFailed && !hasWon)
            {
                sceneScript.LoadMainMenu();
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
