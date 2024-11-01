using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal2 : MonoBehaviour
{
    public zasobnik Zasobnik;
    [SerializeField]
    GameObject celTeleportacji;
    [SerializeField]
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Gracz" && Zasobnik.liczba_zasobnikow == 2)
        {
            other.gameObject.transform.position = celTeleportacji.transform.position;

        }
    }
}
