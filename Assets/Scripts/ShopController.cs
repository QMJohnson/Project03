using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopController : MonoBehaviour
{
    [SerializeField] Text _goldTextView;
    public int gold = 1000;

    private void Update()
    {
        //gets gold and displays it on canvas
        
        _goldTextView.text = gold.ToString();
    }
}
