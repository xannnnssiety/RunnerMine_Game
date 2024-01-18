using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class AdRew : MonoBehaviour
{
    // Подписываемся на событие открытия рекламы в OnEnable
    private void OnEnable() => YandexGame.RewardVideoEvent += Rewarded;

    // Отписываемся от события открытия рекламы в OnDisable
    private void OnDisable() => YandexGame.RewardVideoEvent -= Rewarded;

    // Подписанный метод получения награды
    void Rewarded(int id)
    {
        AddMoney();
    }

    // Метод для вызова видео рекламы
    public void ExampleOpenRewardAd(int id)
    {
        // Вызываем метод открытия видео рекламы
        YandexGame.RewVideoShow(id);
    }

    public void AddMoney()
    {

        PlayerController.coins += 2000;
        PlayerPrefs.SetInt("coins", PlayerController.coins);
    }



}
