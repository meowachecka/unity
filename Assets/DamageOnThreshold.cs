using UnityEngine;
#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif

public class DamageOnThreshold : MonoBehaviour
{
    private int count = 0;
    public int baseDamage = 7;

    void Update()
    {
        bool pressed = false;

#if ENABLE_INPUT_SYSTEM
        if (Keyboard.current != null)
            pressed = Keyboard.current.qKey.wasPressedThisFrame;
#else
        pressed = Input.GetKeyDown(KeyCode.Q);
#endif

        if (!pressed) return;

        
        count++;

        
        if (count == 3)
        {
            for (int level = 1; level <= 5; level++)
            {
                int damage = baseDamage * level;
                Debug.Log(baseDamage + " x " + level + " = " + damage);
            }

            
            Debug.Log("---");
            count = 0;
        }
    }
}