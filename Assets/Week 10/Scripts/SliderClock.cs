using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class SliderClock : MonoBehaviour
{
    public Slider slider;
    float timer;
    public float Speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime * Speed;
        timer = timer % 60;
        slider.value = timer;
    }
}
