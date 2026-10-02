using UnityEngine;

public class Stats : MonoBehaviour
{
    [Header("Bars")]
    public float maxHealth;
    [HideInInspector] public float currentHealth;
    public float maxHunger;
    [HideInInspector] public float currentHunger;

    [Header("Other")]
    public float Damage;

    public bool isDead;

    private void Start()
    {
        currentHealth = maxHealth;
        currentHunger = maxHunger;
    }

    private void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        if (currentHunger > maxHunger)
        {
            currentHunger = maxHunger;
        }
    }
}
