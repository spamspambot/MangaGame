using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    public float dur = 2F;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("DestroyObject");
    }

    IEnumerator DestroyObject() {
        yield return new WaitForSeconds(dur);
        Destroy(gameObject);

    }
}
