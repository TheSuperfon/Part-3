using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CustomerController : MonoBehaviour
{
    public static int CustomerChoose;
    public TextMeshProUGUI Score;
    public float realscore;
    public static Customer ChosenCustomer;
    public Customer adultone;
    public Customer childOne;
    public static bool choose;

    bool OKToReset;
    
    public static string PlayerDrinkChoice;
    public static string CustomerDrinkchoice;
    // Start is called before the first frame update
    void Start()
    {
        PlayerDrinkChoice = "none";
        CustomerDrinkchoice = "zero";
        realscore = 0;
        choose = true;
        CustomerChoose = 5;
        OKToReset = true;
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

        if (PlayerDrinkChoice == CustomerDrinkchoice)
        {
            //if (OKToReset == true)
            //{
            //StartCoroutine(StringReset(1));


            //}
            realscore += 1;
            StartCoroutine(AnotherStringReset(1));
            
        }

        if (PlayerDrinkChoice != "none")
        {
            if (OKToReset == true)
            {
                StartCoroutine(StringReset(1));
                

            }

        }

        


        Score.text = realscore.ToString();

        if (choose == false) return;
        if (CustomerChoose <= 5)
        {
            //Debug.Log(CustomerChoose);
            adultone.StartBarTrip();
 
        }
        if (CustomerChoose > 5)
        {
            //Debug.Log(CustomerChoose);
            childOne.StartBarTrip();
        }

    }

    public IEnumerator StringReset(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        if (OKToReset == false)
        {
            PlayerDrinkChoice = "none";
            
        }
    }
    public IEnumerator AnotherStringReset(float seconds)
    {
         PlayerDrinkChoice = "Served";
         yield return new WaitForSeconds(seconds);
         PlayerDrinkChoice = "none";
    }


}
