using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wrotaxd : MonoBehaviour
{
    [SerializeField]
    GameObject wrotaaa;
    // Start is called before the first frame update
    void Start()
    {
        wrotaaa.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Gracz")
        {
            wrotaaa.gameObject.SetActive(true);

        }
    }
}
