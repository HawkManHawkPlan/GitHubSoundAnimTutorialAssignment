using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
	public AudioClip clip1, clip2;
    public AudioSource musicSource;
	private void Update()
	{
        if (Input.GetKeyDown(KeyCode.W))
        {
            musicSource.clip = clip1;
            musicSource.Play();

        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            musicSource.Stop();

        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            musicSource.clip = clip2;
            musicSource.Play();
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            musicSource.Stop();

        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            musicSource.loop = true;
        }

        if (Input.GetKeyUp(KeyCode.L))
        {
            musicSource.loop = false;
        }
    }
}
