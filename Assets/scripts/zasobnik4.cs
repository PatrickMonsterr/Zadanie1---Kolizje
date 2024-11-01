using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zasobnik4 : MonoBehaviour
{
    public Renderer cubeRenderer;
    public zasobnik Zasobnik;
    // Start is called before the first frame update
    void Start()
    {
        cubeRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Gracz"))
        {

            Debug.Log("KOLIZJA");
            cubeRenderer.material.color = new Color(0f, 0.8f, 0.4f);
        }
    }

   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Gracz" && cubeRenderer.material.color == new Color(0f, 0.8f, 0.4f))
        {

            Zasobnik.liczba_zasobnikow++;
            Destroy(gameObject);
            Debug.Log(Zasobnik.liczba_zasobnikow);

            //if (Zasobnik.liczba_zasobnikow == 4)
            //{
            //    Destroy(other.gameObject);
            //    Application.Quit();
            //}

        }
    }
}
