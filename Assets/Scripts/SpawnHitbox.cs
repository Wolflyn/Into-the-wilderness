using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent(typeof(TopDownMovement))]
[RequireComponent(typeof(Stats))]

public class SpawnHitbox : MonoBehaviour
{
    public float attackRadius = 5f;
    public LayerMask attackLayer;
    public LayerMask eatLayer;
    private TopDownMovement topDown;
    private float foodValue = 5;
    //private Stats playerStats;


    void Awake()
    {
        topDown = GetComponent<TopDownMovement>();
    }
    
    public void Interact(InputAction.CallbackContext ctx)
    {
        if (ctx.ReadValue<float>() == 0)
            return;

        RaycastHit2D hit = Physics2D.CircleCast(transform.position + (Vector3)topDown.direction, attackRadius, Vector2.zero,0, attackLayer);
        
        if(hit)
        {
            if(hit.collider.TryGetComponent(out Stats targetStats) && TryGetComponent(out Stats playerStats))
            {
                float CalculatedDamage = playerStats.Damage;
                targetStats.currentHealth -= CalculatedDamage;
            }
            // Destroy(hit.collider.gameObject, 0);
        }

        RaycastHit2D eat = Physics2D.CircleCast(transform.position + (Vector3)topDown.direction, attackRadius, Vector2.zero, 0, eatLayer);

        if (eat)
        {
            Debug.Log(eat.collider.gameObject.name);

            if (TryGetComponent(out Stats playerStats)) // FIX THISSS!!!! how to get it off player stats and on player script stats(make a new get component to grap script)
            {

                //playerStats = GetComponent<Stats>(); // (code destroys player for some reason(DO NOT TURN ON))
                playerStats.currentHunger += foodValue; 
                Destroy(eat.collider.gameObject, 0);
            }
            
            
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position + (Vector3)topDown.direction, attackRadius);
    }
}
