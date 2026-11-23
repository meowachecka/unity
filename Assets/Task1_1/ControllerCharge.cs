using UnityEngine;

public class ControllerCharge : MonoBehaviour
{
    public Renderer indicator;
    public int charge = 0;

    void Start()
    {
        
        while (charge < 100)
        {
            charge += 25;
            Debug.Log("Charge: " + charge + "%");
        }

        
        if (indicator != null)
        {
            indicator.material.color = Color.green;
        }

    
        Debug.Log("Controller ready!");
    }
}