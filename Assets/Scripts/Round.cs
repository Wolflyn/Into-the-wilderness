using System.Collections;
using UnityEngine;
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
        GameObject.Find("Enemy Spawner").TryGetComponent<EnemySpawn>(out EnemySpawn Spawner);
        pause = false;
        Stats.reset();
        Spawner.SpawnEnemy();

        //if (Spawner.enemyAmount <= 0)
        //{
        //    Ratio change();
        //}

    }
}


