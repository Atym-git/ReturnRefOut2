using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class SaladMaker : MonoBehaviour
{
    [SerializeField] private string[] ingredients = {"oil", "eggs", "salt", "pepper"};

    private bool receipt;
    private void Awake()
    {
        
        //1 - Full call
        if (TryCook(ingredients, out string result))
        {
            Debug.Log(receipt);
        }
        else
        {
            Debug.Log("Error 404");
        }
        //2 Call for logic
        TryCook(ingredients, out string _);
        //3 Call for bool
        if (TryCook(ingredients, out var _))
        {

        }
    }


    private bool TryCook(string ingredientA,string ingredientB,
        string ingredientC,string ingredientD, out string result)
    {
        result = null;

        return false;
    }

    private bool TryCook(string[] ingredients, out string result)
    {
        result = null;
        for (int i = 0; i < ingredients.Length; i++)
    {
            for (int j = 0; j < ingredients.Length; j++)
        {
                if (ingredients[j] == "oil" || ingredients[j] == "eggs" || ingredients[j] == "salt" || ingredients[j] == "peppers")
            {
                    receipt = true;
            }
            else
            {
                    receipt = false;
            }
        }
    }
        if (receipt)
            return true;
        else
            return false;
    }
   
}
