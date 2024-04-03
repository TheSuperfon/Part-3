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

    public static bool MinusPoint;

    bool OKToReset;
    
    public static string PlayerDrinkChoice;
    public static string CustomerDrinkchoice;
    // Start is called before the first frame update
    void Start()
    {
        MinusPoint = false;
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
                StringReset();
                

            }

        }

        if (MinusPoint == true)
        {
            realscore -= 1;
            MinusPoint = false;
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

    public void StringReset()
    {
        //yield return new WaitForSeconds(seconds);
        if (OKToReset == true)
        {
            PlayerDrinkChoice = "none";
            OKToReset = false;
        }
    }
    public IEnumerator AnotherStringReset(float seconds)
    {
         PlayerDrinkChoice = "Served";
         yield return new WaitForSeconds(seconds);
         OKToReset = false;
         //PlayerDrinkChoice = "none";
    }

    

}
