using UnityEngine;

public class ControllerState : MonoBehaviour
{
    public Renderer indicator;
    public int mode = 2;

    void Start()
    {
        string name = mode switch
        {
            0 => "Idle",
            1 => "Tracking",
            2 => "Menu",
            3 => "Paused",
            _ => "Unknown"
        };

        Color color = mode switch
        {
            0 => Color.gray,
            1 => Color.blue,
            2 => Color.yellow,
            3 => Color.magenta,
            _ => Color.red
        };

        if (indicator != null)
        {
            indicator.material.color = color;
        }

        Debug.Log("Mode: " + name);
    }
}