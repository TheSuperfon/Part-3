using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI TimerUI;
    public GameObject Blockade;
    public float RealTimer;
    public bool TimerActive;
    // Start is called before the first frame update
    void Start()
    {
        Blockade.SetActive(false);
        RealTimer = 60;
        TimerActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (TimerActive == true)
        {
            RealTimer -= Time.deltaTime;
            TimerUI.text = RealTimer.ToString();


        }
        if (RealTimer <= 0)
        {

            TimerActive = false;
            RealTimer = 0;
            TimerUI.text = RealTimer.ToString();
            Blockade.SetActive(true);
        }
    }
}
