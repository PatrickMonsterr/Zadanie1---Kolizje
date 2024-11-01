using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pojawienieportalu : MonoBehaviour
{
    [SerializeField]
    GameObject portal;
    [SerializeField]
    GameObject zasobnik3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject enemy = GameObject.FindWithTag("przeciwnik");
        
        if (enemy == null)
        {
           
            portal.SetActive(true);
            zasobnik3.SetActive(true);
            this.enabled = false;
        }
    }
}
