using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    // combine with spawnhitbox because interact and spawnhitbox use the same area
    // please delete script
    
    public void touch(InputAction.CallbackContext ctx)
    {
        if (ctx.ReadValue<float>() == 0)
            return;

        

    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, new Vector2(1.5f, 1.5f));
    }
}
