using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

    public static Transform playerSpawnPoint;

    [SerializeField]
    private Color activatedColor;
    [SerializeField]
    private Color deactivatedColor;

    private bool isActive = false;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = deactivatedColor;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ActivateCheckpoint();
        }
    }

    private void ActivateCheckpoint()
    {
        isActive = true;
        playerSpawnPoint = gameObject.transform;
        spriteRenderer.color = activatedColor;
        
    }

}

