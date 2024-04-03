using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soda : Drinks
{
    protected override void OnMouseDown()
    {
        //Debug.Log("soda");
        CustomerController.PlayerDrinkChoice = "soda";

        if ((CustomerController.CustomerDrinkchoice) != "soda")
        {
            Incorrect();

        }
    }
}
