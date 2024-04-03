using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    public Transform Starposition;
    public Transform Endposition;
    public GameObject SpeechBubble;
    public GameObject angerobject;
    public GameObject beerImage;
    public GameObject SodaImage;
    public GameObject juiceImage;
    public float choiceOption;
    public float Delay;
    public float CustomerWait;
    public float walkspeed;
    public bool ChildChosen;
    public bool adultChosen;

    public bool beerOption;


    // Start is called before the first frame update
    void Start()
    {
        beerOption = false;
         
        Delay = 0.2f;

    }

    // Update is called once per frame
    protected virtual void Update()
    {


    }

    public void StartBarTrip()
    {
        //Debug.Log("ok");
        CustomerController.choose = false;//since the customer has been chosen stops customercontroller from continuing to choose
        StartCoroutine(ToTheBar(Random.Range(0.5f, 3f))); //starts the customer going to the bar and randomizes how fast they walk to the bar

    }


    public IEnumerator ToTheBar(float walktime)
    {

        yield return new WaitForSeconds(Delay); //delay a little bit
        float remainingtime = 0;

        while (remainingtime < walktime) //while the remaining time is less than the randomly assigned walktime the code below is ran
        {
            transform.position = Vector3.Lerp(Starposition.position, Endposition.position, (remainingtime)); //the position of the customer will go from the public and determined start position toward the end position 
            remainingtime += Time.deltaTime;
            yield return null;
        }

        yield return new WaitForSeconds(0.2f);
        StartCoroutine(OrderAtBar(Random.Range(2f, 3.5f))); //randomizes how long customers will spend ordering
    }

    protected virtual IEnumerator OrderAtBar(float OrderTime)
    {
        float remainingtime = 0; //resets remaining time so that customer can get out of here when the time comes
        SpeechBubble.SetActive(true); //sets the speech bubble active so that they can say order 
        choiceOption = Random.Range(1, 4); //randomly choose choice of drink 
        if (choiceOption == 1)
        {
            beerOption = true;



            
        }
        if (choiceOption == 2)
        {
            SodaImage.SetActive(true);
            CustomerController.CustomerDrinkchoice = "soda";
        }
        if (choiceOption == 3)
        {
            juiceImage.SetActive(true);
            CustomerController.CustomerDrinkchoice = "juice";
        }

        yield return new WaitForSeconds(OrderTime); 
        while (remainingtime < OrderTime) 
        {
            
            remainingtime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        remainingtime = 0;
        SpeechBubble.SetActive(false);
        beerImage.SetActive(false);
        SodaImage.SetActive(false);
        juiceImage.SetActive(false);
        CustomerController.CustomerDrinkchoice = "zero";
        while (remainingtime < 1f) //same as the tothebar while loop lerp except in reverse as the customer is leaving the bar
        {
            transform.position = Vector3.Lerp(Endposition.position, Starposition.position, (remainingtime));
            remainingtime += Time.deltaTime;
            yield return null;
        }

        CustomerController.CustomerChoose = Random.Range(2,10); //randomizes value so that it will be either child or adult customer
        CustomerController.choose = true;//allows the customercontroller update to be functional and can choose to activate child or adult

    }

   
}
