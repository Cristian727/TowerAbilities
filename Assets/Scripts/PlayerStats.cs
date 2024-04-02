using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    SpriteRenderer sp;

    [SerializeField] int maxHealth;
    [SerializeField] int currentHealth = 0;
    [SerializeField] Gradient damageColor;
    [SerializeField] GameObject GameOverUI;

    // Start is called before the first frame update
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator GetDamage(int damage)
    {
        currentHealth -= damage;

        float hurt = 1f * damage / currentHealth;
        sp.color = damageColor.Evaluate(hurt);

        if (currentHealth <= 0)
        {
            ShowGameOverScreen();
        }

        yield return null;
    }

    public void ApplyDamage(int damage)
    {
        StartCoroutine(GetDamage(damage));
    }

    void ShowGameOverScreen()
    {
        GameOverUI.SetActive(true);
    }

}