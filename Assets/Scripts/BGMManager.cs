using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMManager : MonoBehaviour
{
    public AudioClip noBGM;
    public AudioClip chillBGM;
    public AudioClip romanticBGM;
    public AudioClip villainBGM;
    public AudioClip comebackBGM;
    AudioSource audiosource;
    public static BGMManager instance = null;
    // Start is called before the first frame update

    void Awake()
    {
        audiosource = GetComponent<AudioSource>();

        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnLevelWasLoaded()
    {
        if(SceneManager.GetActiveScene().buildIndex == 0)
        {
            audiosource.clip = chillBGM;
        }
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            audiosource.clip = romanticBGM;
            audiosource.Play();
        }
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            audiosource.clip = villainBGM;
            audiosource.Play();
        }
        if (SceneManager.GetActiveScene().buildIndex == 9)
        {
            audiosource.clip = comebackBGM;
            audiosource.Play();
        }
        if (SceneManager.GetActiveScene().buildIndex == 12)
        {
            audiosource.Stop();
        }
    }
}
