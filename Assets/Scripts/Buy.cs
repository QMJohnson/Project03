using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buy : MonoBehaviour
{
    [SerializeField] AudioClip _spend;
    public ShopController shopController;

    public void buyItem(int price)
    {
        shopController.gold -= price;
        AudioHelper.PlayClip2D(_spend, 1);
        Debug.Log("SOLD!");
    }
}
