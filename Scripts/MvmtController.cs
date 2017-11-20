using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MvmtController : MonoBehaviour {

    Rigidbody2D rb;
    public float maxSpeed = 10f;
    bool facingRight = true;
    private int count;
    public Text countText;

    Animator anim;
    private AudioSource audioSource;

    bool grounded = false;
    bool flying = false;
    public string FlightTrigger;
    public Transform groundCheck;
    float groundRadius = 0.2f;
    public LayerMask whatIsGround;
    public float jumpForce = 700f;

    void Start () {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        count = 0;
        SetCountText();

	}
	
    void OpenParachute()
    {
        rb.drag = 15;
    }

	void FixedUpdate ()
    {

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

        anim.SetBool("Ground", grounded);
        anim.SetFloat("vSpeed", rb.velocity.y);

        float move = Input.GetAxis("Horizontal");


        anim.SetFloat("Speed", Mathf.Abs(move));

        rb.velocity = new Vector2(move * maxSpeed, rb.velocity.y);

        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();
	}

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    private void Update()
    {
        if (grounded && Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("Ground", false);
            rb.AddForce(new Vector2(0, jumpForce));
            audioSource.Play();
        }

        

        //DRAG
        if (Input.GetKeyDown(KeyCode.LeftShift))
            OpenParachute();
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            rb.drag = 0;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            //flying = true;
            anim.SetBool("Flying", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            anim.SetBool("Flying", false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag ("Pickup"))
        {
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Coins: " + count.ToString();
    }
}
