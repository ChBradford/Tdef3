using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip clacksound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        clacksound = Resources.Load<AudioClip>("clack");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        if (clip == "clack")
        {
            audioSrc.PlayOneShot(clacksound);
        }
    }
}
