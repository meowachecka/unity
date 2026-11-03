using UnityEngine;
#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif

public class ColorByParity : MonoBehaviour
{
    private int count = 0;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        if (rend == null)
        {
            Debug.LogError("На объекте " + gameObject.name + " нет Renderer! Прикрепите скрипт к Cube.");
        }
    }

    void Update()
    {
        if (rend == null) return;

        bool pressed = false;

#if ENABLE_INPUT_SYSTEM
        if (Keyboard.current != null)
            pressed = Keyboard.current.eKey.wasPressedThisFrame;
#else
        pressed = Input.GetKeyDown(KeyCode.E);
#endif

        if (pressed)
        {
            count++;

            string colorName;
            if (count % 2 == 0)
            {
                rend.material.color = Color.red;
                colorName = "red";
            }
            else
            {
                rend.material.color = Color.blue;
                colorName = "blue";
            }

            Debug.Log("Count: " + count + ", color: " + colorName);
        }
    }
}