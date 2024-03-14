using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Thief : Villager
{
    public GameObject DaggerPrefab;
    public Transform DaggerspawnPoint;
    public Transform DaggerspawnPoint2;
    protected override void Attack()
    {
        Mouseclicking();
        speed = 12;
        base.Attack();
        SpawnDagger();
        Invoke("Spawn2ndDagger", 0.2f);
    }



    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }

    void SpawnDagger()
    {
        Instantiate(DaggerPrefab, DaggerspawnPoint.position, DaggerspawnPoint.rotation);

    }
    void Spawn2ndDagger()
    {
        Instantiate(DaggerPrefab, DaggerspawnPoint2.position, DaggerspawnPoint2.rotation);
        speed = 3;
        destination = transform.position;
    }

}
