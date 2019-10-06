 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatScript : MonoBehaviour
{

    public AudioSource musicSource;
    public AudioClip musicClipOne;
    public AudioClip musicClipTwo;
    Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            musicSource.clip = musicClipOne;
            musicSource.Play();
            Anim.SetInteger("state", 1);
        }

        if (Input.GetKeyUp(KeyCode.W))
       {
            musicSource.Stop();
            Anim.SetInteger("state", 0);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            musicSource.clip = musicClipTwo;
            musicSource.Play();
            Anim.SetInteger("state", 2);
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            musicSource.Stop();
            Anim.SetInteger("state", 0);
        }

        if (Input.GetKey("escape"))
            Application.Quit();
    }
}
