using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
[RequireComponent(typeof(UpgradeInput))]

public class Round : MonoBehaviour
{

    public bool pause = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TryGetComponent<UpgradeInput>(out UpgradeInput UpgrdTnpt);
        UpgrdTnpt.StatController = 0;
        RatioChange();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void RatioChange()
    {
        
        TryGetComponent<UpgradeInput>(out UpgradeInput UpgrdTnpt);
        UpgrdTnpt.enable();
        UpgrdTnpt.StatController = 1;

        
            pause = true;

       
        while(UpgrdTnpt.StatController != 0)
        {

        }
            UpgrdTnpt.disable();
       
        //began() *
    }
}



/*
   current script:

   get script.player(stats)*;
   

     Awake()
     {
        Ratio change()*;
     }

     began()
     {
        get script.Enemyspawn*;
        Enemyspawn*.SpawnEnemies(); // enemy spawn(controls what stats enemies spawn with too)
        Stats.Start()*; // resets stats
        pause = false;

        if(enemy killed)
        {
            if(player.TryGetComponent(out Stats playerStats)*)
            {
             playerStats*.score += 1;
            }
        }
        if(enemyAmount <= 0)
        {
            Ratio change();
        }
       }

    

   */

