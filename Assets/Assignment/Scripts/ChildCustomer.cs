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
            CustomerController.CustomerDrinkchoice = "Reject";
            beerOption = false;
            Debug.Log("Reject");
        }
        if ((SpeechBubble.activeInHierarchy) == true)
        {
            Debug.Log("childSpeeking");
        }
        
    }
}
