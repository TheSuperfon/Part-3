using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    public Transform Starposition;
    public Transform Endposition;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = Starposition;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ToTheBar()
    {
        yield return new WaitForSeconds(0.2f);
        
        
    }


}
