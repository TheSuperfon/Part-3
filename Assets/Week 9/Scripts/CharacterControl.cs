using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterControl : MonoBehaviour
{
    public TextMeshProUGUI VillagerName;
    public static Villager SelectedVillager { get; private set; }
    public static void SetSelectedVillager(Villager villager)
    {
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
    }
    
    protected void Update()
    {

        
        if (SelectedVillager == null)
        {
            VillagerName.text = ("None Selected");
        }
        else
        {
            VillagerName.text = SelectedVillager.ToString();
        }
    }



}
