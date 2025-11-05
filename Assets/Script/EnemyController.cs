using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyController : MonoBehaviour
{
    private int countEnemy;
    private System.Random random = new System.Random();

    public GameObject enemy;
    public float timeBtwShots;
    public float startTimeBtwShots;

    // Start is called before the first frame update
    void Start()
    {
        countEnemy = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwShots <= 0)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                var temp = Instantiate(enemy, new Vector3(11, random.Next(-4, 4), 0), new Quaternion(0, 0, 0, 0));
                temp.GetComponent<Enemy>().hp = random.Next(3, 10);
                temp.GetComponent<Enemy>().speed = random.Next(2, 10);

                timeBtwShots = startTimeBtwShots;
            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
