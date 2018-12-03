using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodScript : MonoBehaviour
{
    public CameraScript camScript;
    public int state;
    public GameObject chopsticks;
    public GameObject target;
    Vector3 startPos;
    Vector3 zeroVector = Vector3.zero;
    public List<Transform> positions;
    public List<float> velocities;
    public List<GameObject> sfx;
    public float threshold = 0.1F;
    bool reversed;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = chopsticks.transform.GetChild(0).GetComponent<Animator>();
        camScript = Camera.main.GetComponent<CameraScript>();
        startPos = chopsticks.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("t"))
        {
            NextState();
            camScript.NextCamera();
        }

        switch (state)
        {
            case 05:
                if (Input.GetMouseButtonDown(0)) NextState();
                break;
            case 04:
                if (!anim.GetCurrentAnimatorStateInfo(0).IsName("Pickup"))
                {
                    if (!reversed)
                    {
                        //chopsticks.transform.Translate(velocities[1], 0, 0);
                        chopsticks.transform.position = Vector3.SmoothDamp(chopsticks.transform.position, positions[6].position, ref zeroVector, velocities[3]);
                        if (Vector3.Distance(chopsticks.transform.position, positions[6].position) < threshold) reversed = true;
                    }

                    else
                    {
                        // chopsticks.transform.Translate(velocities[0], 0, 0);
                        chopsticks.transform.position = Vector3.SmoothDamp(chopsticks.transform.position, positions[7].position, ref zeroVector, velocities[3]);
                        if (Vector3.Distance(chopsticks.transform.position, positions[7].position) < threshold) reversed = false;
                    }



                    if (Input.GetMouseButtonDown(0))
                    {
                        anim.SetTrigger("Button");
                    }
                }
                break;
            case 03:
                if (!anim.GetCurrentAnimatorStateInfo(0).IsName("Pickup"))
                {
                    if (!reversed)
                    {
                        //chopsticks.transform.Translate(velocities[1], 0, 0);
                        chopsticks.transform.position = Vector3.SmoothDamp(chopsticks.transform.position, positions[4].position, ref zeroVector, velocities[2]);
                        if (Vector3.Distance(chopsticks.transform.position, positions[4].position) < threshold) reversed = true;
                    }

                    else
                    {
                        // chopsticks.transform.Translate(velocities[0], 0, 0);
                        chopsticks.transform.position = Vector3.SmoothDamp(chopsticks.transform.position, positions[5].position, ref zeroVector, velocities[2]);
                        if (Vector3.Distance(chopsticks.transform.position, positions[5].position) < threshold) reversed = false;
                    }



                    if (Input.GetMouseButtonDown(0))
                    {
                        anim.SetTrigger("Button");
                    }
                }
                break;
            case 02:
                if (!anim.GetCurrentAnimatorStateInfo(0).IsName("Pickup"))
                {
                    if (!reversed)
                    {
                        //chopsticks.transform.Translate(velocities[1], 0, 0);
                        chopsticks.transform.position = Vector3.SmoothDamp(chopsticks.transform.position, positions[2].position, ref zeroVector, velocities[1]);
                        if (Vector3.Distance(chopsticks.transform.position, positions[2].position) < threshold) reversed = true;
                    }

                    else
                    {
                        // chopsticks.transform.Translate(velocities[0], 0, 0);
                        chopsticks.transform.position = Vector3.SmoothDamp(chopsticks.transform.position, positions[3].position, ref zeroVector, velocities[1]);
                        if (Vector3.Distance(chopsticks.transform.position, positions[3].position) < threshold) reversed = false;
                    }



                    if (Input.GetMouseButtonDown(0))
                    {
                        anim.SetTrigger("Button");
                    }
                }
                break;
            case 01:
                if (!anim.GetCurrentAnimatorStateInfo(0).IsName("Pickup"))
                {
                    if (!reversed)
                    {
                        //chopsticks.transform.Translate(velocities[1], 0, 0);
                        chopsticks.transform.position = Vector3.SmoothDamp(chopsticks.transform.position, positions[0].position, ref zeroVector, velocities[0]);
                        if (Vector3.Distance(chopsticks.transform.position, positions[0].position) < threshold) reversed = true;
                    }

                    else
                    {
                        // chopsticks.transform.Translate(velocities[0], 0, 0);
                        chopsticks.transform.position = Vector3.SmoothDamp(chopsticks.transform.position, positions[1].position, ref zeroVector, velocities[0]);
                        if (Vector3.Distance(chopsticks.transform.position, positions[1].position) < threshold) reversed = false;
                    }



                    if (Input.GetMouseButtonDown(0))
                    {
                        anim.SetTrigger("Button");
                    }
                }

                break;
            default:
                if (Input.GetMouseButtonDown(0))
                {
                    NextState();
                }
                break;

        }
    }

    public void NextState()
    {
        camScript.NextCamera();
        state++;
        if (sfx.Count >= state) if (sfx[state] != null) Instantiate(sfx[state], transform.position, Quaternion.identity);
        switch (state)
        {
 
            case 05:
                chopsticks.SetActive(false);
                break;
            case 04:

                chopsticks.transform.position = positions[6].position;
                break;
            case 03:
                chopsticks.transform.position = positions[4].position;
                break;
            case 02:
                chopsticks.transform.position = positions[2].position;
                break;
            case 01:
                chopsticks.SetActive(true);
                chopsticks.transform.position = positions[0].position;
                break;
            default:

                break;
        }
    }
}
