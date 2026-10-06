using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent(typeof(Rigidbody2D))]
public class TopDownMovement : MonoBehaviour
{
    [SerializeField] private float walkSped = 5f;
    [SerializeField] private float runSped = 10f;
    
    private float currentSped;
    private Vector2 movement; //[HideInInspector] public Vector2 movement; DO NOT USE, this is a note for future projects
    [HideInInspector] public Vector2 direction;
    private Rigidbody2D rb2D;
    

    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        currentSped = walkSped;
        direction = Vector2.down;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TryGetComponent(out Stats playerStats);
        runSped = playerStats.spedLvl * 10;
        rb2D.linearVelocity = movement * currentSped;
    }

    public void Move(InputAction.CallbackContext ctx)
    {
        movement = ctx.ReadValue<Vector2>();

        if(ctx.ReadValue<Vector2>() != Vector2.zero)
        {
            direction = ctx.ReadValue<Vector2>();
        }
    }

    public void Run(InputAction.CallbackContext ctx)
    {
        if (ctx.ReadValue<float>() == 1) /* pressed */
        {
            currentSped = runSped;
        }
        else // Released
        {
            currentSped = walkSped;
        }
    }
}
