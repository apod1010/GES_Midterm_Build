using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static AudioClip music, death, coin, jump;
    static AudioSource audioSource;

	// Use this for initialization
	void Start () {
        jump = Resources.Load<AudioClip>("Jump5");
        death = Resources.Load<AudioClip>("Hit_Hurt16");
        coin = Resources.Load<AudioClip>("Pickup_Coin7");

        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "Jump5":
                audioSource.PlayOneShot(jump);
                break;
            case "Hit_Hurt16":
                audioSource.PlayOneShot(death);
                break;
            case "Pickup_Coin7":
                audioSource.PlayOneShot(coin);
                break;
        }
    }
}


