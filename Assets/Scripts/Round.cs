using UnityEngine;
using System.Collections;

[RequireComponent(typeof(UpgradeInput))]

public class Round : MonoBehaviour
{

    public bool pause = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TryGetComponent<UpgradeInput>(out UpgradeInput UpgrdTnpt);
        UpgrdTnpt.StatController = 0;
        StartCoroutine(RatioChange());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public IEnumerator RatioChange()
    {
        
        TryGetComponent<UpgradeInput>(out UpgradeInput UpgrdTnpt);
        UpgrdTnpt.enable();
        UpgrdTnpt.StatController = 1;

        
            pause = true;


        //(UpgrdTnpt.StatController != 0)
        yield return new WaitUntil(() => UpgrdTnpt.StatController == 0);



            UpgrdTnpt.disable();
            

        Play();
    }

    public void Play()
    {
        TryGetComponent<Stats>(out Stats Stats);
        pause = false;
        Stats.reset();
    }
}



/*
   current script:

   get script.player(stats)*;
   

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

