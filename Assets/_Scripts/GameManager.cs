using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject trailGame1;
    public GameObject trailGame2;
    public GameObject trailGame3;
    public GameObject trailGame4;
    public GameObject trailGame5;
    public GameObject trailGame6;
    public GameObject trailGame7;
    public GameObject trailGame8;
    public GameObject trailGame9;
    public GameObject trailGame10;
    public GameObject trailGame11;


    public GameObject GameOver;


    void Start()
    {
        GameOver.SetActive(false);

        PlayerPrefs.GetInt("trail1");
        PlayerPrefs.GetInt("trail2");
        PlayerPrefs.GetInt("trail3");
        PlayerPrefs.GetInt("trail4");
        PlayerPrefs.GetInt("trail5");
        PlayerPrefs.GetInt("trail6");
        PlayerPrefs.GetInt("trail7");
        PlayerPrefs.GetInt("trail8");
        PlayerPrefs.GetInt("trail9");
        PlayerPrefs.GetInt("trail10");
        PlayerPrefs.GetInt("trail11");


        if (ShopBuy.trail1 == 1)
        {
            trailGame1.SetActive(true);

        }

        if (ShopBuy.trail2 == 1)
        {

            trailGame2.SetActive(true);

        }

        if (ShopBuy.trail3 == 1)
        {

            trailGame3.SetActive(true);

        }

        if (ShopBuy.trail4 == 1)
        {

            trailGame4.SetActive(true);

        }

        if (ShopBuy.trail5 == 1)
        {

            trailGame5.SetActive(true);

        }

        if (ShopBuy.trail6 == 1)
        {

            trailGame6.SetActive(true);

        }

        if (ShopBuy.trail7 == 1)
        {

            trailGame7.SetActive(true);

        }

        if (ShopBuy.trail8 == 1)
        {

            trailGame8.SetActive(true);

        }

        if (ShopBuy.trail9 == 1)
        {

            trailGame9.SetActive(true);

        }

        if (ShopBuy.trail10 == 1)
        {

            trailGame10.SetActive(true);

        }

        if (ShopBuy.trail11 == 1)
        {

            trailGame11.SetActive(true);

        }



    }

    // Update is called once per frame
    void Update()
    {
        if (Deadzone.HP == 0)
        {
            GameOver.SetActive(true);
        }
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ResetGame()
    {
        Deadzone.HP = 1;
        SceneManager.LoadScene(1);
    }
}
