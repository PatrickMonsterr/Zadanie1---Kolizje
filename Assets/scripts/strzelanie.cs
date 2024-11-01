using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strzelanie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {


            {
                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.forward, out hit, 5))
                {
                    if (hit.collider.gameObject.name == "przeciwnik")
                    {
                        Destroy(hit.collider.gameObject);
                       //hit.collider.gameObject.SetActive(false);
                    }
                }
            }
        }
    }
}
