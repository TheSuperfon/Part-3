using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerController : MonoBehaviour
{
    public bool IsSpawned;
    public List<Customer> customers;
    // Start is called before the first frame update
    void Start()
    {
        IsSpawned = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsSpawned == false)
        {
            Debug.Log("spawned");
            IsSpawned = true;
            
        }
        
        
        
    }
}
