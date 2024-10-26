using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSFX : MonoBehaviour
{

    public AudioSource playSound;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        playSound.Play();
    }
}