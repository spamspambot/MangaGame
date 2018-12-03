using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeechBubbleScript : MonoBehaviour
{
    public float offset;
    public AudioSource AS;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Delay");
        AS = GetComponent<AudioSource>();
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)) Destroy(gameObject);
    }

    IEnumerator Delay() {
        yield return new WaitForSeconds(offset);
        AS.Play();
    }
}
