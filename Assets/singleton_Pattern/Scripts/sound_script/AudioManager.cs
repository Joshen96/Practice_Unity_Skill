using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    static AudioManager _instance = null;

    public static AudioManager Instance()
    {
        return _instance;
    }

    private void Start()
    {
        if (_instance == null)
        {
            _instance = this;
        }
    }

    public void Play(AudioClip _clip)
    {
        GetComponent<AudioSource>().PlayOneShot(_clip);
    }

}
