using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class AdRew : MonoBehaviour
{
    // ������������� �� ������� �������� ������� � OnEnable
    private void OnEnable() => YandexGame.RewardVideoEvent += Rewarded;

    // ������������ �� ������� �������� ������� � OnDisable
    private void OnDisable() => YandexGame.RewardVideoEvent -= Rewarded;

    // ����������� ����� ��������� �������
    void Rewarded(int id)
    {
        AddMoney();
    }

    // ����� ��� ������ ����� �������
    public void ExampleOpenRewardAd(int id)
    {
        // �������� ����� �������� ����� �������
        YandexGame.RewVideoShow(id);
    }

    public void AddMoney()
    {

        PlayerController.coins += 2000;
        PlayerPrefs.SetInt("coins", PlayerController.coins);
    }



}
