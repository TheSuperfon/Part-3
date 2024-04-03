using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Juice : Drinks
{
    protected override void OnMouseDown()
    {
        Debug.Log("juice");
        CustomerController.PlayerDrinkChoice = "juice";
    }
}
