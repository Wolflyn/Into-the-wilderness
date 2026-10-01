using UnityEngine;
using UnityEngine.UI;

public class StatsHud : MonoBehaviour
{
    public Stats stats;
    public Image healthBar;
    public Image hungerBar;

    void Update()
    {
        healthBar.fillAmount=stats.currentHealth/stats.maxHealth;
        hungerBar.fillAmount = stats.currentHunger / stats.maxHunger;
    }
}
