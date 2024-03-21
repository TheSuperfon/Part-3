using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterControl : MonoBehaviour
{
    public TMPro.TextMeshProUGUI currentSelection;
    public TMP_Dropdown dropdownmenu;
    public static CharacterControl Instance;
    public static Villager SelectedVillager { get; private set; }
    public Villager TheThief;
    public Villager TheArcher;
    public Villager TheMerchant;
    public Transform Thieftransform;
    public Transform Archertransform;
    public Transform Merchanttransform;
    public string villagername;
    public Slider slider;
    public static void SetSelectedVillager(Villager villager)
    {
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
        //Instance.currentSelection.text = villager.ToString();
    }

    private void Update()
    {
        //if(SelectedVillager != null)
        //{
        //    currentSelection.text = SelectedVillager.GetType().ToString();
        //}
    }
    private void Start()
    {
        Instance = this;
    }

    public void Characterchange(int index)
    {
        //Debug.Log(dropdownmenu.options[index].text);
        villagername = dropdownmenu.options[index].text;
        
        if (villagername == ("Thief"))
        {
            //Debug.Log(villagername);
            Instance.currentSelection.text = villagername;
            SetSelectedVillager(TheThief);
            
        }
        if (villagername == ("Merchant"))
        {
            //Debug.Log(villagername);
            Instance.currentSelection.text = villagername;
            SetSelectedVillager(TheMerchant);
        }
        if (villagername == ("Archer"))
        {
            //Debug.Log(villagername);
            Instance.currentSelection.text = villagername;
            SetSelectedVillager(TheArcher);
        }


        
    }

    public void Sizechange(Single Change)
    {

        if (villagername == ("Thief"))
        {
            //Thieftransform.localScale -= (Change;

        }
        if (villagername == ("Merchant"))
        {
            //SetSelectedVillager(TheMerchant);
        }
        if (villagername == ("Archer"))
        {
            //SetSelectedVillager(TheArcher);
        }


        
    }

}
