using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deadzone : MonoBehaviour
{

    public static int HP;

    public void Start()
    {
        HP = 1;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            HP = 0;
            Time.timeScale = 0;
        }
    }
}
