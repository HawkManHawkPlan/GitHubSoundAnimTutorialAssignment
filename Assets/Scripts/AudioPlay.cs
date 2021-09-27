using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
	public AudioClip clip1, clip2;
    public AudioSource musicSource;
    public Animator anim;
	private void Update()
	{
        if (Input.GetKeyDown(KeyCode.W))
        {
            musicSource.clip = clip1;
            musicSource.Play();
            anim.SetInteger("State", 1);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            musicSource.Stop();
            anim.SetInteger("State", 0);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            musicSource.clip = clip2;
            musicSource.Play();
            anim.SetInteger("State", 2);
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            musicSource.Stop();
            anim.SetInteger("State", 0);
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
