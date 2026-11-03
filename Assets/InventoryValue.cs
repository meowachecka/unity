using UnityEngine;
#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif

public class InventoryValue : MonoBehaviour
{
    private int count = 0;
    private int coinValue = 10;

    void Update()
    {
        bool pressed = false;

#if ENABLE_INPUT_SYSTEM
        if (Keyboard.current != null)
            pressed = Keyboard.current.spaceKey.wasPressedThisFrame;
#else
        pressed = Input.GetKeyDown(KeyCode.Space);
#endif

        if (!pressed) return;

        // Добавляем монету
        count++;

        // При достижении 5 монет считаем стоимость циклом
        if (count == 5)
        {
            int totalValue = 0;

            for (int i = 1; i <= count; i++)
            {
                totalValue += coinValue;
            }

            // Вывод
            Debug.Log("Coins: " + count + ", total value: " + totalValue);

            // Очищаем инвентарь
            count = 0;
        }
    }
}