using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAudioPlay : MonoBehaviour
{
    public AudioClip clip;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground")) 
        {
            AudioManager.Instance().Play(clip);
            Destroy(this.gameObject);
        }
    }
}
