using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealAbility : Ability
{
    [SerializeField] float healing;
    public override void Trigger(Vector3 directionToCursor)
    {
        print("trigger desde ClaseHija2 con cura " + healing);
    }


}
