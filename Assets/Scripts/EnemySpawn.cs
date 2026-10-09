using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;

    private bool roundStart;
    public int enemyAmount=0;


    public void SpawnEnemy()
    {
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        enemyAmount += 1;
    }
}
