using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    public Transform Starposition;
    public Transform Endposition;
    public GameObject SpeechBubble;
    public GameObject angerobject;
    public float Delay;
    public float CustomerWait;
    public float walkspeed;
    public List<Drinks> drinks;


    // Start is called before the first frame update
    void Start()
    {
        //walkspeed = 
        Delay = 0.2f;
        //CustomerWait = 
        StartCoroutine(ToTheBar(Random.Range(0.5f, 3f)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ToTheBar(float walktime)
    {
        yield return new WaitForSeconds(Delay);
        float remainingtime = 0;

        while (remainingtime < walktime)
        {
            transform.position = Vector3.Lerp(Starposition.position, Endposition.position, (remainingtime));
            remainingtime += Time.deltaTime;
            yield return null;
        }

        yield return new WaitForSeconds(0.5f);
        StartCoroutine(OrderAtBar(Random.Range(3f, 6f)));
    }

    IEnumerator OrderAtBar(float OrderTime)
    {
        yield return new WaitForSeconds(Delay);
        float remainingtime = 0;
        SpeechBubble.SetActive(true);
        yield return new WaitForSeconds(OrderTime);
        /*while (remainingtime < OrderTime)
        {
            
            remainingtime += Time.deltaTime;
            yield return null;
        }*/
        SpeechBubble.SetActive(false);
        while (remainingtime < 1f)
        {
            transform.position = Vector3.Lerp(Endposition.position, Starposition.position, (remainingtime));
            remainingtime += Time.deltaTime;
            yield return null;
        }
        







    }


}
