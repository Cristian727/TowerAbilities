using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Ability : MonoBehaviour
{
    [SerializeField] string abilityName;
    [SerializeField] float coolDown;

    public float coolDownTime;
    public float lastShot;
    public Image abilityImage;


    public abstract void Trigger(Vector3 directionToCursor);


    //NO SE ME VE EL COOLDOWN EN LA PANTALLA :(

    public void Cooldown()
    {
        float coolDownBar = Mathf.Clamp01((Time.time - lastShot) / coolDownTime);
        abilityImage.fillAmount = coolDownBar;

        if (Time.time - lastShot >= coolDownTime)
        {
            abilityImage.fillAmount = coolDownTime;

        }
    }
}
