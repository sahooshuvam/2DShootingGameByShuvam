using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMovement : MonoBehaviour
{
    public float enemySpeed;
    Rigidbody2D rb;
    public ScoreManager score;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-enemySpeed,rb.velocity.y);
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
        score.ScoreCalculator(10);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "DestroyPoint")
        {
            Destroy(gameObject);
        }
    }


}
