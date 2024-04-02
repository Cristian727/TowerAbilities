using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityHolder : MonoBehaviour
{
    [SerializeField] List<Ability> abilities;
    int selectedAbilityIndex = 0;
    Vector3 mousePosition;


    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            selectedAbilityIndex = 0;
        if (Input.GetKeyDown(KeyCode.Alpha2))
            selectedAbilityIndex = 1;
        if (Input.GetKeyDown(KeyCode.Alpha3))
            selectedAbilityIndex = 2;
        if (Input.GetKeyDown(KeyCode.Alpha4))
            selectedAbilityIndex = 3;
        if (Input.GetKeyDown(KeyCode.Alpha5))
            selectedAbilityIndex = 4;


        //Vector3 movementInput = Vector3.zero;
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        Vector3 directionToCursor = mousePosition - transform.position;

        //transform.rotation = Quaternion.LookRotation(Vector3.forward, directionToCursor);
        transform.up = directionToCursor;


        if (Input.GetMouseButtonDown(0))
            abilities[selectedAbilityIndex].Trigger(directionToCursor);

        //print(Input.mousePosition);
        //Camera.main.ScreenToWorldPoint
        //transform.up
        //Vector3.SignedAngle
    }
}
