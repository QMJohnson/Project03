using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buy : MonoBehaviour
{
    [SerializeField] Button _test;
    public ShopController shopController;

    public void buyItem(int price)
    {
        shopController.gold -= price;
        Debug.Log("SOLD!");
    }
}
