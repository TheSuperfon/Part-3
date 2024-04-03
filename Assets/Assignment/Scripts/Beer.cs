using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class Beer : Drinks
{
    protected override void OnMouseDown()
    {
        Debug.Log("beer");
        CustomerController.PlayerDrinkChoice = "beer";
    }
}
