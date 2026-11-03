using UnityEngine;
#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif

public class TwoKeyCounter : MonoBehaviour
{
    private int count = 0;

    void Update()
    {
        bool aPressed = false;
        bool dPressed = false;

#if ENABLE_INPUT_SYSTEM
        if (Keyboard.current != null)
        {
            aPressed = Keyboard.current.aKey.wasPressedThisFrame;
            dPressed = Keyboard.current.dKey.wasPressedThisFrame;
        }
#else
        aPressed = Input.GetKeyDown(KeyCode.A);
        dPressed = Input.GetKeyDown(KeyCode.D);
#endif

        // Если ничего не нажато, ничего не делаем
        if (!aPressed && !dPressed) return;

        if (aPressed)
        {
            count++;
        }
        else if (dPressed)
        {
            count--;
        }

        Debug.Log("Count: " + count);

        if (count < 0)
        {
            Debug.Log("Negative!");
            count = 0;
        }

        if (count == 5)
        {
            Debug.Log("Max reached!");
            count = 0;
        }
    }
}