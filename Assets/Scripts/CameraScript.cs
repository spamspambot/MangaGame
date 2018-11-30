using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    Camera cam;
    public List<Transform> positions;
    public List<float> camSizes;
    public List<float> velocities;
    public int state;
    public bool moving;

    public float velocity;
    Vector3 zeroVector = Vector3.zero;
    float zeroFloat = 0F;
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
        state++;
        moving = true;
    }
}
