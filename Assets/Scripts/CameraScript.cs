using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraScript : MonoBehaviour
{
    Camera cam;
    public List<Transform> positions;
    public List<float> camSizes;
    public List<float> velocities;
    public List<GameObject> sfx;
    public int state;
    public int nextScene;
    public bool moving;
    Vector3 zeroVector = Vector3.zero;
    float zeroFloat = 0F;
    public bool noSkip;
    public float threshold;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r") && !moving) NextCamera();
        if (moving && state < positions.Count)
        {
            transform.position = Vector3.SmoothDamp(transform.position, positions[state].position, ref zeroVector, velocities[state]);
            cam.orthographicSize = Mathf.SmoothDamp(cam.orthographicSize, camSizes[state], ref zeroFloat, velocities[state]);
            if (Vector3.Distance(transform.position, positions[state].position) < threshold)
            {
                moving = false;
            }
        }
    }

    public void NextCamera()
    {
        if(state == positions.Count-1 && !noSkip)
        {
            SceneManager.LoadScene(nextScene);
        }
        state++;
        if (sfx.Count >= state)
            if (sfx[state] != null) Instantiate(sfx[state], transform.position, Quaternion.identity);
        moving = true;
    }

    public void ScreenShake()
    {

    }

}
