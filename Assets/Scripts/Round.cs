using UnityEngine;

public class Round : MonoBehaviour
{
    


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
     Changes to stats:

        [hideInInspector]public int score = 0;
        
            //stat upgrades
        // low = 1
        // high = 3
        [range: 1-3]public int healthLvl = 1;
        [range: 1-3]public int damageLvl = 1; 
        [range: 1-3]public int spedLvl = 1;

        Update()
        {
            
           maxHealth = healthLvl*10;
           damage = damageLvl*2;
            
        }
*/

/*
    changes to TopDownMovement 
    
    get script.player(stats)*;
    
    Update()
    {
        runSped = player.spedLvl*10;
    }
*/


/*
   current script:

   get script.player(stats)*;
   get script.Enemyspawn*;
   get script.timeController;

     Awake()
     {
        
        Ratio change();
     }

    


     began()
     {
        Enemyspawn*.SpawnEnemies(); // enemy spawn(controls what stats enemies spawn with too)
        Stats.Start()*; // resets stats
        timeController.Unpause(); // allows for player and enemies to input. enables decay

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
            timeController.pause();
            change a stat by -1 thats above zero();
            change a stat by 1 thats below maximum();
            began()
        }

   */