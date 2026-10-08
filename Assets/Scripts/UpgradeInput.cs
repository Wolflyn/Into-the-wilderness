using UnityEngine;
using UnityEngine.InputSystem;


public class UpgradeInput : MonoBehaviour
{
    public int pointLim = 5;
    private int placeholder = 1; // to make button work, do not make it equal 0
    [Range(0, 2)] public int StatController; // what part of chosing is the player in when chosing stats. 0 = off, 1 = can take a point, 2 = can give a point 

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject[] buttons; 


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

        //Debug.Log(StatController);
    }


























    public void HealthDwn()
    {
        TryGetComponent<Stats>(out Stats stats);
        if (stats.healthLvl > 1 && StatController == 1)
        {
            stats.healthLvl -= 1;
            StatController = 2;
        }
    }

    public void SpedDwn()
    {
        TryGetComponent<Stats>(out Stats stats);
        if (stats.spedLvl > 1 && StatController == 1)
        {
            stats.spedLvl -= 1;
            StatController = 2;
        }
    }

    public void DamageDwn()
    {
        TryGetComponent<Stats>(out Stats stats);
        if (stats.damageLvl > 1 && StatController == 1)
        {
            stats.damageLvl -= 1;
            StatController = 2;
        }
    }



    public void HealthUp()
    {
        TryGetComponent<Stats>(out Stats stats);
        if (stats.totalLvl < pointLim && stats.healthLvl < 3 && StatController == 2)
        {
            stats.healthLvl += 1;
            StatController = 0;
        }
    }

    public void SpedUp()
    {
        TryGetComponent<Stats>(out Stats stats);
        if (stats.totalLvl < pointLim && stats.spedLvl < 3 && StatController == 2)
        {
            stats.spedLvl += 1;
            StatController = 0;
        }
    }

    public void DamageUp()
    {
        TryGetComponent<Stats>(out Stats stats);
        if (stats.totalLvl < pointLim && stats.damageLvl < 3 && StatController == 2)
        {
            stats.damageLvl += 1;
            StatController = 0;
        }
    }

    public void disable()
    {
        foreach(GameObject button in buttons)
        {
            button.SetActive(false);
        }
    }

    public void enable()
    {
        foreach (GameObject button in buttons)
        {
            button.SetActive(true);
        }
    }
}
