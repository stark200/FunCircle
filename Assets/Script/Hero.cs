using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    Rigidbody2D myBody;
    public float speed = 45.0f;

    int score;

    GameControl gameControl;
    // Use this for initialization
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        gameControl = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControl>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * speed;
        float vertical = Input.GetAxis("Vertical") * speed;
        myBody.AddForce(new Vector2(horizontal, vertical));
    }
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Gem")
        {
            Destroy(other.gameObject);
            score++;
            gameControl.ChangeScore(score);
        }
    }

}

