using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour
{
    public zasobnik Zasobnik;
    [SerializeField]
    GameObject celTeleportacji;
    [SerializeField]
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Gracz" && Zasobnik.liczba_zasobnikow == 1)
        {
            other.gameObject.transform.position = celTeleportacji.transform.position;
            
        }
    }
}
