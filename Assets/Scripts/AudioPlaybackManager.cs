using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlaybackManager : MonoBehaviour
{
    public AudioSource audioPlayer;

    // Start is called before the first frame update
    public void PlayAudio()
    {
        audioPlayer.Play();
    }
}
