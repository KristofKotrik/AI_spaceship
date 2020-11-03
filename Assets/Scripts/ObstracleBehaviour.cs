using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstracleBehaviour : MonoBehaviour
{

    public Rigidbody2D rb;
    public float fallSpd = 10f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position.Set(Random.Range(-6f, 6f), 6f, 0f);
        //rb.AddForce(Vector2.down * fallSpd);
        rb.velocity = Vector2.down * fallSpd;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector2.down * fallSpd;
        if (transform.position.y <= -6)
        {
            transform.position = new Vector3(Random.Range(-6f, 6f), 6f, 0f);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.velocity = Vector2.down * fallSpd;
    }
}
