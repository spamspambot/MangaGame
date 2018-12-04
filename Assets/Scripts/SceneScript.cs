using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    AsyncOperation asyncLoad;
    public float delay;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("o")) LoadMainMenu();
    }

    public void LoadMainMenu()
    {
    
        StartCoroutine("ReturnToMain");
    }


    IEnumerator ReturnToMain()
    {
        asyncLoad = SceneManager.LoadSceneAsync(0);
        asyncLoad.allowSceneActivation = false;
        yield return new WaitForSeconds(delay);
        asyncLoad.allowSceneActivation = true;
        while (!asyncLoad.isDone) { yield return null; }


    }
}
