using UnityEngine;
using System.Collections;

public class ChargeColor : MonoBehaviour
{
    public Renderer indicator;
    public int charge = 0;

    void Start()
    {
        StartCoroutine(ChargeRoutine());
    }

    IEnumerator ChargeRoutine()
    {
        while (charge < 100)
        {
            charge += 25;

            Color chosenColor;
            if (charge < 50) chosenColor = Color.red;
            else if (charge < 100) chosenColor = Color.yellow;
            else chosenColor = Color.green;

            if (indicator != null)
                indicator.material.color = chosenColor;

            Debug.Log("Charge: " + charge + "%");

            yield return new WaitForSeconds(0.5f);
        }
    }
}