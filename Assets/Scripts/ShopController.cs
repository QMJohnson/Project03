using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopController : MonoBehaviour
{
    [SerializeField] Text _goldTextView;

    private void Update()
    {

        //gets highscore and displays it on canvas
        int gold = 1000;
        _goldTextView.text = gold.ToString();
    }
}
