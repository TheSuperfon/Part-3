using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclineScript : Drinks
{
    protected override void OnMouseDown()
    {
        //Debug.Log("Reject");
        CustomerController.PlayerDrinkChoice = "Reject";
    }
}
