using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Text menuMoney;
    public GameObject shop;

    public void Start()
    {
        Deadzone.HP = 1;
    }

    private void Update()
    {
        menuMoney.text = PlayerController.coins.ToString();
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void DeleteKeys()
    {
        PlayerPrefs.DeleteAll();
    }

    public void OpenShop()
    {
        shop.SetActive(true);
    }

    public void CloseShop()
    {
        shop.SetActive(false);
    }

}
