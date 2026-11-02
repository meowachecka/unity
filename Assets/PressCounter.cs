using UnityEngine;

public class PressCounter : MonoBehaviour
{
    private int count = 0;
    private bool fiveReached = false; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            count++;
            Debug.Log("Press count: " + count);

            if (count >= 5 && !fiveReached)
            {
                fiveReached = true;
                Debug.Log("Five presses reached!");
            }
        }
    }
}