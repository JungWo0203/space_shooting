using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    int type;
    float size;
    [SerializeField] float meteorSpeed = -0.1f;
    // Start is called before the first frame update
    void Start()
    {
        type = Random.Range(1, 4);
        if (type == 1) // small
        {
            small_meteor();
        }
        if (type == 2)
        {
            middle_meteor();
        }
        if (type == 3)
        {
            big_meteor();
        }
        transform.localScale = new Vector3(size, size, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - meteorSpeed);
    }

    void big_meteor()
    {
        size = 0.5f;
    }
    void middle_meteor()
    {
        size = 1.0f;
    }

    void small_meteor()
    {
        size = 1.5f;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            /*playerdie();*/
        }
        if (collision.gameObject.tag == "Meteorout")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            if (type == 2)
            {
                Instantiate(gameObject, gameObject.transform.position, transform.rotation);
            }
            if (type == 3)
            {
                Instantiate(gameObject, gameObject.transform.position, transform.rotation);
            }
        }
    }
}