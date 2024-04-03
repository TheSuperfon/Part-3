using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdultCustomer : Customer
{
    protected override void Update()
    {
        if (beerOption == true)
        {
            beerImage.SetActive(true);
            CustomerController.CustomerDrinkchoice = "beer"; //the function unique to adult which means only adult can get points from beer
            beerOption = false;
        }

    }
}
