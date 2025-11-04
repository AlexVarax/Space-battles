using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet; //Снаряд
    public Transform firePoint; //Точка, с которой будут отправляться снаряды и лучи

    public LineRenderer lineRenderer; //Луч

    void ShootBullet()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightControl)) //Если игрок нажал на правый Ctrl
        {
            //Вызов метода стрельбы снарядами
            ShootBullet();

            //Вызов метода стрельбы лучами
            //StartCoroutine(Shoot());
            //Выберите один из них
        }
    }
}
