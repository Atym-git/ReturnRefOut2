using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI itemName;
    [SerializeField] private TextMeshProUGUI itemPrice;

    public void DrawItemInfo(string name, float price)
    {
        itemName.text = name;
        itemPrice.text = $"{price} $";
    }



}
