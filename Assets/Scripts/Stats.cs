using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Stats : MonoBehaviour
{
    
    
    
    [Header("Levels")]
    [Range(1,3)] public int healthLvl = 1;
    [Range(1,3)] public int damageLvl = 1;
    [Range(1,3)] public int spedLvl = 1;
    public int totalLvl = 0;

    [Header("Bars")]
    public float maxHealth;
    [HideInInspector] public float currentHealth;
    public float maxHunger;
    [HideInInspector] public float currentHunger;
    [HideInInspector] public int score;

    [Header("Other")]
    public float Damage;

    public bool isDead;
    
    private void Start()
    {
        score = 0;
        currentHealth = maxHealth;
        currentHunger = maxHunger;
    }

    public void reset()
    {
        currentHealth = maxHealth;
        currentHunger = maxHunger;
    }

    private void Update()
    {

        totalLvl = healthLvl + damageLvl + spedLvl;
        maxHealth = healthLvl * 10;
        Damage = damageLvl * 2;

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
