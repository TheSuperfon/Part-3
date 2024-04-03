using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerController : MonoBehaviour
{
    public static int CustomerChoose;

    //public List<Customer> CustomerList;
    public static Customer ChosenCustomer;
    public Customer adultone;
    public Customer childOne;
    public static bool choose;
    
    public string PlayerDrinkChoice;
    public string CustomerDrinkchoice;
    // Start is called before the first frame update
    void Start()
    {
        choose = true;
        CustomerChoose = 5;
        //adultone.ToTheBar(Random.Range(0.5f, 3f));
        
    }

    public static void ActivateCustomer()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (IsSpawned == false)
        {
            Debug.Log("spawned");
            IsSpawned = true;
            
        }*/

        if (choose == false) return;
        if (CustomerChoose <= 5)
        {
            Debug.Log(CustomerChoose);
            //chosenOne. ;
            adultone.StartBarTrip();
 
        }
        if (CustomerChoose > 5)
        {
            Debug.Log(CustomerChoose);
            childOne.StartBarTrip();
        }

    }

    public void AdultChosen()
    {
        
    }


}
