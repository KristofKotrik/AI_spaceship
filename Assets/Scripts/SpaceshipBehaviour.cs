using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipBehaviour : MonoBehaviour
{

    public Rigidbody2D rb;
    public SpriteRenderer spriteRen;
    public Transform RightRay;
    public Transform LeftRay;
    float movement = 0f;
    public float movSpeed = 3000f;

    private bool isAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        movement = Input.GetAxisRaw("Horizontal");
        RaycastHit2D RHit = Physics2D.Raycast(RightRay.position, RightRay.up);
        RaycastHit2D LHit = Physics2D.Raycast(LeftRay.position, LeftRay.up);

        if (RHit) { Debug.Log(RHit.transform.name); }
        if (LHit) { Debug.Log(LHit.transform.name); }

    }

    void FixedUpdate()
    {
        rb.AddForce(new Vector2(movement * movSpeed * Time.fixedDeltaTime, 0f));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isAlive = false;
        Destroy(gameObject);
    }
}
