using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zasobnik2 : MonoBehaviour
{
    public zasobnik Zasobnik;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Gracz")
        {
          
            Zasobnik.liczba_zasobnikow++;
            gameObject.SetActive(false);
           
        }
    }
}
