using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Script controls the volume in the scene.
public class SoundScene : MonoBehaviour
{
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Gamemanager.Instance.sound >=1)
        {
            audioSource.volume = Random.Range(0.01f, 0.03f);
        }
    }
}
