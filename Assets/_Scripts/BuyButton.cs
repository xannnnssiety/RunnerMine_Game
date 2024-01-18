using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyButton : MonoBehaviour
{
    public int btnBuy1;
    public int btnBuy2;
    public int btnBuy3;
    public int btnBuy4;
    public int btnBuy5;
    public int btnBuy6;
    public int btnBuy7;
    public int btnBuy8;
    public int btnBuy9;
    public int btnBuy10;
    public int btnBuy11;
    public int btnBuy12;

    public GameObject btn1;
    public GameObject btn2;
    public GameObject btn3;
    public GameObject btn4;
    public GameObject btn5;
    public GameObject btn6;
    public GameObject btn7;
    public GameObject btn8;
    public GameObject btn9;
    public GameObject btn10;
    public GameObject btn11;
    public GameObject btn12;

    public GameObject notMoney;

    public void CloseNotMoney()
    {
        notMoney.SetActive(false);
    }

    void Start()
    {
        btnBuy1 = PlayerPrefs.GetInt("Btn1");
        btnBuy2 = PlayerPrefs.GetInt("Btn2");
        btnBuy3 = PlayerPrefs.GetInt("Btn3");
        btnBuy4 = PlayerPrefs.GetInt("Btn4");
        btnBuy5 = PlayerPrefs.GetInt("Btn5");
        btnBuy6 = PlayerPrefs.GetInt("Btn6");
        btnBuy7 = PlayerPrefs.GetInt("Btn7");
        btnBuy8 = PlayerPrefs.GetInt("Btn8");
        btnBuy9 = PlayerPrefs.GetInt("Btn9");
        btnBuy10 = PlayerPrefs.GetInt("Btn19");
        btnBuy11 = PlayerPrefs.GetInt("Btn11");
        btnBuy12 = PlayerPrefs.GetInt("Btn12");
    }

    private void Update()
    {
        if(btnBuy1 == 1)
        {
            btn1.SetActive(false);
        }
        if (btnBuy2 == 1)
        {
            btn2.SetActive(false);
        }
        if (btnBuy3 == 1)
        {
            btn3.SetActive(false);
        }
        if (btnBuy4 == 1)
        {
            btn4.SetActive(false);
        }
        if (btnBuy5 == 1)
        {
            btn5.SetActive(false);
        }
        if (btnBuy6 == 1)
        {
            btn6.SetActive(false);
        }
        if (btnBuy7 == 1)
        {
            btn7.SetActive(false);
        }
        if (btnBuy8 == 1)
        {
            btn8.SetActive(false);
        }
        if (btnBuy9 == 1)
        {
            btn9.SetActive(false);
        }
        if (btnBuy10 == 1)
        {
            btn10.SetActive(false);
        }
        if (btnBuy11 == 1)
        {
            btn11.SetActive(false);
        }
        if (btnBuy12 == 1)
        {
            btn12.SetActive(false);
        }
    }

    public void Buy1()
    {
        if (PlayerController.coins >= 100)
        {
            btnBuy1 = 1;

            PlayerPrefs.SetInt("Btn1", btnBuy1);
            PlayerController.coins -= 100;
            PlayerPrefs.SetInt("coins", PlayerController.coins);
        }
        else
        {
            notMoney.SetActive(true);
        }
    }

    public void Buy2()
    {
        if (PlayerController.coins >= 100)
        {
            btnBuy2 = 1;

            PlayerPrefs.SetInt("Btn2", btnBuy2);
            PlayerController.coins -= 100;
            PlayerPrefs.SetInt("coins", PlayerController.coins);
        }
        else
        {
            notMoney.SetActive(true);
        }
    }

    public void Buy3()
    {
        if (PlayerController.coins >= 100)
        {
            btnBuy3 = 1;

            PlayerPrefs.SetInt("Btn3", btnBuy3);
            PlayerController.coins -= 100;
            PlayerPrefs.SetInt("coins", PlayerController.coins);
        }
        else
        {
            notMoney.SetActive(true);
        }
    }

    public void Buy4()
    {
        if (PlayerController.coins >= 1000)
        {
            btnBuy4 = 1;

            PlayerPrefs.SetInt("Btn4", btnBuy4);
            PlayerController.coins -= 1000;
            PlayerPrefs.SetInt("coins", PlayerController.coins);
        }
        else
        {
            notMoney.SetActive(true);
        }
    }

    public void Buy5()
    {
        if (PlayerController.coins >= 1000)
        {
            btnBuy5 = 1;

            PlayerPrefs.SetInt("Btn5", btnBuy5);
            PlayerController.coins -= 1000;
            PlayerPrefs.SetInt("coins", PlayerController.coins);
        }
        else
        {
            notMoney.SetActive(true);
        }
    }

    public void Buy6()
    {
        if (PlayerController.coins >= 1000)
        {
            btnBuy6 = 1;

            PlayerPrefs.SetInt("Btn6", btnBuy6);
            PlayerController.coins -= 1000;
            PlayerPrefs.SetInt("coins", PlayerController.coins);
        }
        else
        {
            notMoney.SetActive(true);
        }
    }

    public void Buy7()
    {
        if (PlayerController.coins >= 5000)
        {
            btnBuy7 = 1;

            PlayerPrefs.SetInt("Btn7", btnBuy7);
            PlayerController.coins -= 5000;
            PlayerPrefs.SetInt("coins", PlayerController.coins);
        }
        else
        {
            notMoney.SetActive(true);
        }
    }

    public void Buy8()
    {
        if (PlayerController.coins >= 5000)
        {
            btnBuy8 = 1;

            PlayerPrefs.SetInt("Btn8", btnBuy8);
            PlayerController.coins -= 5000;
            PlayerPrefs.SetInt("coins", PlayerController.coins);
        }
        else
        {
            notMoney.SetActive(true);
        }
    }

    public void Buy9()
    {
        if (PlayerController.coins >= 5000)
        {
            btnBuy9 = 1;

            PlayerPrefs.SetInt("Btn9", btnBuy9);
            PlayerController.coins -= 5000;
            PlayerPrefs.SetInt("coins", PlayerController.coins);
        }
        else
        {
            notMoney.SetActive(true);
        }
    }

    public void Buy10()
    {
        if (PlayerController.coins >= 10000)
        {
            btnBuy10 = 1;

            PlayerPrefs.SetInt("Btn10", btnBuy10);
            PlayerController.coins -= 10000;
            PlayerPrefs.SetInt("coins", PlayerController.coins);
        }
        else
        {
            notMoney.SetActive(true);
        }
    }

    public void Buy11()
    {
        if (PlayerController.coins >= 25000)
        {
            btnBuy11 = 1;

            PlayerPrefs.SetInt("Btn11", btnBuy11);
            PlayerController.coins -= 25000;
            PlayerPrefs.SetInt("coins", PlayerController.coins);
        }
        else
        {
            notMoney.SetActive(true);
        }
    }

    public void Buy12()
    {
        if (PlayerController.coins >= 50000)
        {
            btnBuy12 = 1;

            PlayerPrefs.SetInt("Btn12", btnBuy12);
            PlayerController.coins -= 50000;
            PlayerPrefs.SetInt("coins", PlayerController.coins);
        }
        else
        {
            notMoney.SetActive(true);
        }
    }
}
