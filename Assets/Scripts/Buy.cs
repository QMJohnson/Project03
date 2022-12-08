using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buy : MonoBehaviour
{
    [SerializeField] AudioClip _spend;
    public ShopController shopController;

    //function to handle transactions
    public void buyItem(int price)
    {
        shopController.gold -= price; //subtracts price of item from player's gold
        AudioHelper.PlayClip2D(_spend, 1); //sound eff
        Debug.Log("SOLD!");
    }
}
