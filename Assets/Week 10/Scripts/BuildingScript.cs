using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BuildingScript : MonoBehaviour
{
    public Transform Billboardtransform;
    public Transform Signposttransform;
    public Transform lamptransform;
    public Vector3 scalevalue1;
    public Vector3 scalevalue2;
    public Vector3 scalevalue3;
    public Vector3 startvalue;
    public Vector3 endvalue;



    // Start is called before the first frame update
    void Start()
    {
        scalevalue1 = Vector3.zero;
        scalevalue2 = Vector3.zero;
        scalevalue3 = Vector3.zero;
        startvalue = Vector3.zero;
        endvalue = Vector3.one;
        StartCoroutine(Bigbillboard(0));
        StartCoroutine(Signpost(0));
        StartCoroutine(Lamp(0));

    }

    // Update is called once per frame
    void Update()
    {
        Billboardtransform.localScale = scalevalue1;
        Signposttransform.localScale = scalevalue2;
        lamptransform.localScale = scalevalue3;

    }

    IEnumerator Bigbillboard(float billboardtimer)
    {
        yield return new WaitForSeconds(0.1f);

        while (billboardtimer < 1)
        {
            
            scalevalue1 = Vector3.Lerp(startvalue, endvalue, (billboardtimer));
            billboardtimer += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        


        

    }

    IEnumerator Signpost(float signposttimer)
    {
        yield return new WaitForSeconds(1.2f);

        while (signposttimer < 1)
        {

            scalevalue2 = Vector3.Lerp(startvalue, endvalue, (signposttimer));
            signposttimer += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }





    }

    IEnumerator Lamp(float lamptimer)
    {
        yield return new WaitForSeconds(2.3f);

        while (lamptimer < 1)
        {

            scalevalue3 = Vector3.Lerp(startvalue, endvalue, (lamptimer));
            lamptimer += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }





    }




}
