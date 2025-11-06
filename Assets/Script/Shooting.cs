using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting: MonoBehaviour
{
    public float speed;
    public float lifetime;
    public int damage;
    public LayerMask isSolid;

    private void Start()
    {
    }

    private void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, 1, isSolid);

        if (hitInfo.collider != null)
        {
            if (hitInfo.collider.CompareTag("Enemy"))
            {
                hitInfo.collider.GetComponent<Enemy>().TakeDamage(damage);
            }
            Destroy(gameObject);
        }
        if (transform.position.x > 10)
        {
            Destroy(gameObject);
        }

        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

}
