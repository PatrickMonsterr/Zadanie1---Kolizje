using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class portal4 : MonoBehaviour
{
    [SerializeField]
    GameObject zasobnikPrawdziwy;
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
        if (other.gameObject.name == "Gracz" && Zasobnik.liczba_zasobnikow == 4)
        {

            Debug.Log("JEST KOLIZJA");
                Destroy(other.gameObject);
                Application.Quit();
            

        }
    }
   
}
