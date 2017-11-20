using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinPickup : MonoBehaviour {

    static int coinCount = 0;

    [SerializeField]
    private Text coinCountText;

    private AudioSource audioSource;
    private SpriteRenderer spriteRenderer;
    private BoxCollider2D bc2d;

    private void Start()
    {
        //coinCountText = GameObject.Find("CoinCountText").GetComponent<Text>();
        //coinCountText.text = "Coin Count: " + coinCount;
        bc2d = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            audioSource.Play();

            //coinCount++;
            //coinCountText.text = "Coin Count: " + coinCount;
            //Debug.Log("Touched Coin. Coins: " + coinCount);
            spriteRenderer.enabled = false;
            bc2d.enabled = false;
            //Destroy(this.gameObject);

        }

        
    }
}
