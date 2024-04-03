using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class Drinks : MonoBehaviour
{
    public TextMeshProUGUI Serving;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Serving.text = CustomerController.PlayerDrinkChoice;
    }
    protected virtual void OnMouseDown()
    {
        Debug.Log("mouse");
    }

}
