using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Enemy : MonoBehaviour
{
    public int hp;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            gameObject.layer = 0;

            Vector3 objectScale = transform.localScale;
            if (transform.localScale.x > 0.1) 
            {
                SpriteRenderer spr;
                spr = GetComponent<SpriteRenderer>();
                spr.color = new Color();

                transform.localScale = new Vector3(objectScale.x * (float)0.99, objectScale.y*(float)0.99, objectScale.z);
                speed /= 2;
            }
            else
            {
                Destroy(gameObject);
            }

            transform.Translate(Vector2.left * speed * Time.deltaTime);
            transform.Translate(Vector2.up * -1 * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        
        if (transform.position.x < -11)
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        hp--;

    }
}
