using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopBuy : MonoBehaviour
{
    public static int trail1;
    public static int trail2;
    public static int trail3;
    public static int trail4;
    public static int trail5;
    public static int trail6;
    public static int trail7;
    public static int trail8;
    public static int trail9;
    public static int trail10;
    public static int trail11;


    /*public GameObject notMoney;*/


    // Start is called before the first frame update
    void Start()
    {
        trail1 = PlayerPrefs.GetInt("trail1");
        trail2 = PlayerPrefs.GetInt("trail2");
        trail3 = PlayerPrefs.GetInt("trail3");
        trail4 = PlayerPrefs.GetInt("trail4");
        trail5 = PlayerPrefs.GetInt("trail5");
        trail6 = PlayerPrefs.GetInt("trail6");
        trail7 = PlayerPrefs.GetInt("trail7");
        trail8 = PlayerPrefs.GetInt("trail8");
        trail9 = PlayerPrefs.GetInt("trail9");
        trail10 = PlayerPrefs.GetInt("trail10");
        trail11 = PlayerPrefs.GetInt("trail11");



        


    }





    public void SetPlayer1()
    {
   
            trail1 = 1;
            trail2 = 0;
            trail3 = 0;
            trail4 = 0;
            trail5 = 0;
            trail6 = 0;
            trail7 = 0;
            trail8 = 0;
            trail9 = 0;
            trail10 = 0;
            trail11 = 0;

           




        PlayerPrefs.SetInt("trail1", trail1);
        PlayerPrefs.SetInt("trail2", trail2);
        PlayerPrefs.SetInt("trail3", trail3);
        PlayerPrefs.SetInt("trail4", trail4);
        PlayerPrefs.SetInt("trail5", trail5);
        PlayerPrefs.SetInt("trail6", trail6);
        PlayerPrefs.SetInt("trail7", trail7);
        PlayerPrefs.SetInt("trail8", trail8);
        PlayerPrefs.SetInt("trail9", trail9);
        PlayerPrefs.SetInt("trail10", trail10);
        PlayerPrefs.SetInt("trail11", trail11);
    }

    public void SetPlayer2()
    {
        trail1 = 0;
        trail2 = 1;
        trail3 = 0;
        trail4 = 0;
        trail5 = 0;
        trail6 = 0;
        trail7 = 0;
        trail8 = 0;
        trail9 = 0;
        trail10 = 0;
        trail11 = 0;

        PlayerPrefs.SetInt("trail1", trail1);
        PlayerPrefs.SetInt("trail2", trail2);
        PlayerPrefs.SetInt("trail3", trail3);
        PlayerPrefs.SetInt("trail4", trail4);
        PlayerPrefs.SetInt("trail5", trail5);
        PlayerPrefs.SetInt("trail6", trail6);
        PlayerPrefs.SetInt("trail7", trail7);
        PlayerPrefs.SetInt("trail8", trail8);
        PlayerPrefs.SetInt("trail9", trail9);
        PlayerPrefs.SetInt("trail10", trail10);
        PlayerPrefs.SetInt("trail11", trail11);
    }

    public void SetPlayer3()
    {
        trail1 = 0;
        trail2 = 0;
        trail3 = 1;
        trail4 = 0;
        trail5 = 0;
        trail6 = 0;
        trail7 = 0;
        trail8 = 0;
        trail9 = 0;
        trail10 = 0;
        trail11 = 0;

        PlayerPrefs.SetInt("trail1", trail1);
        PlayerPrefs.SetInt("trail2", trail2);
        PlayerPrefs.SetInt("trail3", trail3);
        PlayerPrefs.SetInt("trail4", trail4);
        PlayerPrefs.SetInt("trail5", trail5);
        PlayerPrefs.SetInt("trail6", trail6);
        PlayerPrefs.SetInt("trail7", trail7);
        PlayerPrefs.SetInt("trail8", trail8);
        PlayerPrefs.SetInt("trail9", trail9);
        PlayerPrefs.SetInt("trail10", trail10);
        PlayerPrefs.SetInt("trail11", trail11);
    }

    public void SetPlayer4()
    {
        trail1 = 0;
        trail2 = 0;
        trail3 = 0;
        trail4 = 1;
        trail5 = 0;
        trail6 = 0;
        trail7 = 0;
        trail8 = 0;
        trail9 = 0;
        trail10 = 0;
        trail11 = 0;

        PlayerPrefs.SetInt("trail1", trail1);
        PlayerPrefs.SetInt("trail2", trail2);
        PlayerPrefs.SetInt("trail3", trail3);
        PlayerPrefs.SetInt("trail4", trail4);
        PlayerPrefs.SetInt("trail5", trail5);
        PlayerPrefs.SetInt("trail6", trail6);
        PlayerPrefs.SetInt("trail7", trail7);
        PlayerPrefs.SetInt("trail8", trail8);
        PlayerPrefs.SetInt("trail9", trail9);
        PlayerPrefs.SetInt("trail10", trail10);
        PlayerPrefs.SetInt("trail11", trail11);
    }

    public void SetPlayer5()
    {
        trail1 = 0;
        trail2 = 0;
        trail3 = 0;
        trail4 = 0;
        trail5 = 1;
        trail6 = 0;
        trail7 = 0;
        trail8 = 0;
        trail9 = 0;
        trail10 = 0;
        trail11 = 0;

        PlayerPrefs.SetInt("trail1", trail1);
        PlayerPrefs.SetInt("trail2", trail2);
        PlayerPrefs.SetInt("trail3", trail3);
        PlayerPrefs.SetInt("trail4", trail4);
        PlayerPrefs.SetInt("trail5", trail5);
        PlayerPrefs.SetInt("trail6", trail6);
        PlayerPrefs.SetInt("trail7", trail7);
        PlayerPrefs.SetInt("trail8", trail8);
        PlayerPrefs.SetInt("trail9", trail9);
        PlayerPrefs.SetInt("trail10", trail10);
        PlayerPrefs.SetInt("trail11", trail11);
    }

    public void SetPlayer6()
    {
        trail1 = 0;
        trail2 = 0;
        trail3 = 0;
        trail4 = 0;
        trail5 = 0;
        trail6 = 1;
        trail7 = 0;
        trail8 = 0;
        trail9 = 0;
        trail10 = 0;
        trail11 = 0;

        PlayerPrefs.SetInt("trail1", trail1);
        PlayerPrefs.SetInt("trail2", trail2);
        PlayerPrefs.SetInt("trail3", trail3);
        PlayerPrefs.SetInt("trail4", trail4);
        PlayerPrefs.SetInt("trail5", trail5);
        PlayerPrefs.SetInt("trail6", trail6);
        PlayerPrefs.SetInt("trail7", trail7);
        PlayerPrefs.SetInt("trail8", trail8);
        PlayerPrefs.SetInt("trail9", trail9);
        PlayerPrefs.SetInt("trail10", trail10);
        PlayerPrefs.SetInt("trail11", trail11);
    }

    public void SetPlayer7()
    {
        trail1 = 0;
        trail2 = 0;
        trail3 = 0;
        trail4 = 0;
        trail5 = 0;
        trail6 = 0;
        trail7 = 1;
        trail8 = 0;
        trail9 = 0;
        trail10 = 0;
        trail11 = 0;

        PlayerPrefs.SetInt("trail1", trail1);
        PlayerPrefs.SetInt("trail2", trail2);
        PlayerPrefs.SetInt("trail3", trail3);
        PlayerPrefs.SetInt("trail4", trail4);
        PlayerPrefs.SetInt("trail5", trail5);
        PlayerPrefs.SetInt("trail6", trail6);
        PlayerPrefs.SetInt("trail7", trail7);
        PlayerPrefs.SetInt("trail8", trail8);
        PlayerPrefs.SetInt("trail9", trail9);
        PlayerPrefs.SetInt("trail10", trail10);
        PlayerPrefs.SetInt("trail11", trail11);
    }

    public void SetPlayer8()
    {
        trail1 = 0;
        trail2 = 0;
        trail3 = 0;
        trail4 = 0;
        trail5 = 0;
        trail6 = 0;
        trail7 = 0;
        trail8 = 1;
        trail9 = 0;
        trail10 = 0;
        trail11 = 0;

        PlayerPrefs.SetInt("trail1", trail1);
        PlayerPrefs.SetInt("trail2", trail2);
        PlayerPrefs.SetInt("trail3", trail3);
        PlayerPrefs.SetInt("trail4", trail4);
        PlayerPrefs.SetInt("trail5", trail5);
        PlayerPrefs.SetInt("trail6", trail6);
        PlayerPrefs.SetInt("trail7", trail7);
        PlayerPrefs.SetInt("trail8", trail8);
        PlayerPrefs.SetInt("trail9", trail9);
        PlayerPrefs.SetInt("trail10", trail10);
        PlayerPrefs.SetInt("trail11", trail11);
    }

    public void SetPlayer9()
    {
        trail1 = 0;
        trail2 = 0;
        trail3 = 0;
        trail4 = 0;
        trail5 = 0;
        trail6 = 0;
        trail7 = 0;
        trail8 = 0;
        trail9 = 1;
        trail10 = 0;
        trail11 = 0;

        PlayerPrefs.SetInt("trail1", trail1);
        PlayerPrefs.SetInt("trail2", trail2);
        PlayerPrefs.SetInt("trail3", trail3);
        PlayerPrefs.SetInt("trail4", trail4);
        PlayerPrefs.SetInt("trail5", trail5);
        PlayerPrefs.SetInt("trail6", trail6);
        PlayerPrefs.SetInt("trail7", trail7);
        PlayerPrefs.SetInt("trail8", trail8);
        PlayerPrefs.SetInt("trail9", trail9);
        PlayerPrefs.SetInt("trail10", trail10);
        PlayerPrefs.SetInt("trail11", trail11);
    }

    public void SetPlayer10()
    {
        trail1 = 1;
        trail2 = 1;
        trail3 = 1;
        trail4 = 1;
        trail5 = 1;
        trail6 = 1;
        trail7 = 1;
        trail8 = 1;
        trail9 = 1;
        trail10 = 0;
        trail11 = 0;

        PlayerPrefs.SetInt("trail1", trail1);
        PlayerPrefs.SetInt("trail2", trail2);
        PlayerPrefs.SetInt("trail3", trail3);
        PlayerPrefs.SetInt("trail4", trail4);
        PlayerPrefs.SetInt("trail5", trail5);
        PlayerPrefs.SetInt("trail6", trail6);
        PlayerPrefs.SetInt("trail7", trail7);
        PlayerPrefs.SetInt("trail8", trail8);
        PlayerPrefs.SetInt("trail9", trail9);
        PlayerPrefs.SetInt("trail10", trail10);
        PlayerPrefs.SetInt("trail11", trail11);
    }

    public void SetPlayer11()
    {
        trail1 = 0;
        trail2 = 0;
        trail3 = 0;
        trail4 = 0;
        trail5 = 0;
        trail6 = 0;
        trail7 = 0;
        trail8 = 0;
        trail9 = 0;
        trail10 = 1;
        trail11 = 0;


        PlayerPrefs.SetInt("trail1", trail1);
        PlayerPrefs.SetInt("trail2", trail2);
        PlayerPrefs.SetInt("trail3", trail3);
        PlayerPrefs.SetInt("trail4", trail4);
        PlayerPrefs.SetInt("trail5", trail5);
        PlayerPrefs.SetInt("trail6", trail6);
        PlayerPrefs.SetInt("trail7", trail7);
        PlayerPrefs.SetInt("trail8", trail8);
        PlayerPrefs.SetInt("trail9", trail9);
        PlayerPrefs.SetInt("trail10", trail10);
        PlayerPrefs.SetInt("trail11", trail11);
    }

    public void SetPlayer12()
    {
        trail1 = 0;
        trail2 = 0;
        trail3 = 0;
        trail4 = 0;
        trail5 = 0;
        trail6 = 0;
        trail7 = 0;
        trail8 = 0;
        trail9 = 0;
        trail10 = 0;
        trail11 = 1;


        PlayerPrefs.SetInt("trail1", trail1);
        PlayerPrefs.SetInt("trail2", trail2);
        PlayerPrefs.SetInt("trail3", trail3);
        PlayerPrefs.SetInt("trail4", trail4);
        PlayerPrefs.SetInt("trail5", trail5);
        PlayerPrefs.SetInt("trail6", trail6);
        PlayerPrefs.SetInt("trail7", trail7);
        PlayerPrefs.SetInt("trail8", trail8);
        PlayerPrefs.SetInt("trail9", trail9);
        PlayerPrefs.SetInt("trail10", trail10);
        PlayerPrefs.SetInt("trail11", trail11);
    }


}
