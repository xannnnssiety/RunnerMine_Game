using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    public float speed = 5f;
    public float maxSpeed = 35f;


    private void Start()
    {
        StartCoroutine(SpeedIncrease());
    }
    void Update()
    {
        // Двигаем персонажа вперед по оси Z
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
    }

    private IEnumerator SpeedIncrease()
    {
        yield return new WaitForSeconds(7);
        if(speed < maxSpeed)
        {
            speed += 1;
            StartCoroutine(SpeedIncrease());
        }
        
    }
}
