using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hazard : MonoBehaviour {

    private AudioSource audioSource;

    private void Start()
    {      
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            audioSource.Play();
            if (Checkpoint.playerSpawnPoint == null)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            else
            {
                collision.gameObject.transform.position = Checkpoint.playerSpawnPoint.position;
            }
        }
    }
}
