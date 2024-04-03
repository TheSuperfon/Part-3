using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildCustomer : Customer
{
    protected override void Update()
    {
        if (beerOption == true)
        {
            beerImage.SetActive(true);
            CustomerController.CustomerDrinkchoice = "Reject"; //the function unique to child which means the only way to match and get points is to reject the child since it overrode "beer"
            beerOption = false;
            //Debug.Log("Reject");
        }
               
    }
}
