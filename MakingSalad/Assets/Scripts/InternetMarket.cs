using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InternetMarket : MonoBehaviour
{

    [SerializeField] private GameObject itemViewPrefab;
    [SerializeField] private RectTransform root;
    [Space(20)]
    [SerializeField] private ItemData[] cartItems;

    private void Awake()
    {
        Dictionary<string, float> itemdata = new();
        for (int i = 0;  i < cartItems.Length; i++)
        {
            itemdata.Add(cartItems[i].ItemName, cartItems[i].ItemPrice);
        }
        DrawShoppingCart(itemdata);
    }


    private void DrawShoppingCart(Dictionary<string, float> items)
    {
        foreach(var item in items)
        {
            GameObject viewInstance = Instantiate(itemViewPrefab, root);
            if (viewInstance.TryGetComponent(out ItemView itemView))
            {
                itemView.DrawItemInfo(item.Key, item.Value);
            }
        }
    }
}

[Serializable]
public class ItemData
{
    [field:SerializeField] public string ItemName { get; private set; }
    [field:SerializeField] public float ItemPrice { get; private set; }
}
