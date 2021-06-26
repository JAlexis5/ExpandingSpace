using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;

    // Start is called before the first frame update
    void Start()
    {
        audioSource.time = 96.10625f;
        audioSource.PlayDelayed(2f);
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            ColDetect.WinitSwitch();
            Debug.Log(ColDetect.winit);
            ColDetect.Wincheck();
        }
    }
}