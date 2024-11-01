using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class zasobnik : MonoBehaviour
{
    public int liczba_zasobnikow = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Gracz")
        {
            liczba_zasobnikow ++;
            gameObject.SetActive(false);
        }
    }
}
