using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OjouSamaScript : MonoBehaviour
{
    SceneScript sceneScript;
    public TimerScript timerScript;
    public float dur;
    bool hasStarted = true;
    public GameObject startObject;
    public int state;
    public List<Sprite> sprites;
    SpriteRenderer SR;
    public GameObject sfx;
    // Start is called before the first frame update
    void Start()
    {
        //timerScript = Camera.main.GetComponent<>
        sceneScript = Camera.main.GetComponent<SceneScript>();
        SR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (startObject == null && !hasStarted) { hasStarted = true; timerScript.SetTimer(dur); }

        if (Input.GetMouseButtonDown(0)) { Instantiate(sfx); state++; if (state == 3) { TimerScript.hasWon = true; sceneScript.LoadMainMenu(); } }
        if (!TimerScript.hasFailed)
        {
            if (state == 1) SR.sprite = sprites[0];
            else if (state >= 2) SR.sprite = sprites[1];
        }
        else SR.sprite = sprites[2];

    }
}
