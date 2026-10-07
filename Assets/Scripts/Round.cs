using UnityEngine;

public class Round : MonoBehaviour
{

    public bool pause = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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

    Ratio Change()
        {
            pause = true;
            change a stat by -1 thats above minimum();
            change a stat by 1 thats below maximum();
            began()*
        }

   */