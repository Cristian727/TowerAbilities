using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotAbility : Ability
{
    [SerializeField] float strength;
    [SerializeField] float damage;
    [SerializeField] float speed;

    [SerializeField] GameObject ProyectilePrefab;
    [SerializeField] Transform spawn;

    private void Update()
    {
        Cooldown();
    }

    public override void Trigger(Vector3 directionToCursor)
    {
        print("trigger desde ClaseHija1 con fuerza " + strength);

        GameObject NewProyectile = GameObject.Instantiate(
            ProyectilePrefab,
            spawn.position,
            Quaternion.identity
        );

        LinearMovement projectileMovement = NewProyectile.GetComponent<LinearMovement>();
        projectileMovement.ShotDirection(directionToCursor);
        Destroy(NewProyectile, 2f);

    }


}

    // almacenar una referencia al objeto recién instanciado
    // a ese objeto, pillarle el componente de comportamiento del proyectil
    // sobre ese componente, llamar a la función de pasarle la dirección

  
