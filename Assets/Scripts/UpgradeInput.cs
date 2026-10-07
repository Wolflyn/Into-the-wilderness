using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.InputSystem;

public class UpgradeInput : MonoBehaviour
{
    public int pointLim = 5;
    private int placeholder = 1; // to make button work, do not make it equal 0

    // Start is called once before the first execution of Update after the MonoBehaviour is created


    public void Update()
    {
        if(placeholder == 0 )
        {
            HealthDwn(); 
            SpedDwn();
            DamageDwn();

            HealthUp();
            SpedUp();
            DamageUp();
        }
    }


























    public void HealthDwn()
    {
        TryGetComponent<Stats>(out Stats stats);
        if (stats.healthLvl > 1)
        {
            stats.healthLvl -= 1;
        }
    }

    public void SpedDwn()
    {
        TryGetComponent<Stats>(out Stats stats);
        if (stats.spedLvl > 1)
        {
            stats.spedLvl -= 1;
        }
    }

    public void DamageDwn()
    {
        TryGetComponent<Stats>(out Stats stats);
        if (stats.damageLvl > 1)
        {
            stats.damageLvl -= 1;
        }
    }



    public void HealthUp()
    {
        TryGetComponent<Stats>(out Stats stats);
        if (stats.totalLvl < pointLim && stats.healthLvl < 3)
        {
            stats.healthLvl += 1; 
        }
    }

    public void SpedUp()
    {
        TryGetComponent<Stats>(out Stats stats);
        if (stats.totalLvl < pointLim && stats.spedLvl < 3)
        {
            stats.spedLvl += 1;
        }
    }

    public void DamageUp()
    {
        TryGetComponent<Stats>(out Stats stats);
        if (stats.totalLvl < pointLim && stats.damageLvl < 3)
        {
            stats.damageLvl += 1;
        }
    }
}
