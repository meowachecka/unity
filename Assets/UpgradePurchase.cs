using UnityEngine;
#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif

public class UpgradePurchase : MonoBehaviour
{
    private int count = 0;
    public int gold = 500;
    public int costPerLevel = 20;

    void Update()
    {
        bool pressed = false;

#if ENABLE_INPUT_SYSTEM
        if (Keyboard.current != null)
            pressed = Keyboard.current.rKey.wasPressedThisFrame;
#else
        pressed = Input.GetKeyDown(KeyCode.R);
#endif

        if (!pressed) return;

        // Увеличиваем счётчик улучшений
        count++;

        // При достижении 5 улучшений запускаем цикл от 5 до 1
        if (count == 5)
        {
            for (int level = 5; level >= 1; level--)
            {
                gold -= costPerLevel;
                Debug.Log(level + "... -" + costPerLevel + " gold");
            }

            // Сообщение после цикла
            Debug.Log("Upgrade complete!");

            // Сброс счётчика
            count = 0;
        }
    }
}