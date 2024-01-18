using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyX2 : MonoBehaviour
{
    public GameObject btnX2;
    public GameObject notMoney;

    public Text costX2text;
    public int costX2;
    public int SwapCost;

    private void Start()
    {
        Score.scoreMultiplier = PlayerPrefs.GetInt("scMulti");

    }

    // Update is called once per frame
    void Update()
    {


        costX2text.text = costX2.ToString();

        if (Score.scoreMultiplier <= 1)
        {
            costX2 = 0;
            SwapCost = 0;
        }
        else
        {
            costX2 = 500;
            SwapCost = 500;
        }

        if (Score.scoreMultiplier >= 30)
        {
            btnX2.SetActive(false);
        }
    }

    public void BuyBonusX2()
    {
        if (PlayerController.coins >= SwapCost)
        {
           
            Score.scoreMultiplier += 1;
            PlayerPrefs.SetInt("scMulti", Score.scoreMultiplier);
            PlayerController.coins -= SwapCost;
            PlayerPrefs.SetInt("coins", PlayerController.coins);
        }
        else
        {
            notMoney.SetActive(true);
        }


    }
}
