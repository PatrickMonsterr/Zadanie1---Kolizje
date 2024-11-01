using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wrota4 : MonoBehaviour
{
    [SerializeField]
    GameObject zasobnik2;
    [SerializeField]
    GameObject portal2;

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
            zasobnik2.gameObject.SetActive(true);
            portal2.gameObject.SetActive(true);

        }
    }


}
