using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Villager
{
    public GameObject ArrowPrefab;
    public Transform spawnPoint;
    public float delay = 0.46f;
    protected override void Attack()
    {
        destination = transform.position;

        base.Attack();
        Invoke("SpawnArrow", delay);
    }



    void SpawnArrow()
    {
        Instantiate(ArrowPrefab, spawnPoint.position, spawnPoint.rotation);


    }

    public override ChestType CanOpen()
    {
        return ChestType.Archer;
    }

}
