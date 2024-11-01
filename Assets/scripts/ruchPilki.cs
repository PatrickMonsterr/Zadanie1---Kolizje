using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class ruchPilki : MonoBehaviour
{
    [SerializeField]
    private float szybkosc = 33f;
    private int zmianakierunku = 1;
    private Vector3 ww = new Vector3(0, 0, 1);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.position += ww * szybkosc * zmianakierunku;
    }

    private void OnCollisionStay(Collision collision)
    {

        if (collision.gameObject.tag == "mur2")
        {
           
            zmianakierunku *= -1;
            // transform.collisionInfo.gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();
            int losowanie = Random.Range(0, 3);

           
            switch (losowanie)
            {
                case 0:
                    ww = new Vector3(1, 0, 1);
                    break;
                case 1:
                    ww = new Vector3(-1, 0, 1);
                    break;
                case 2:
                    ww = new Vector3(0, 0, 1);
                    break;
            }






        }
        if (collision.gameObject.tag == "Gracz")
        {
            SceneManager.LoadScene("Scena1");
        }
    }
    //private void OnCollisionEnter(Collision collisionInfo)
    //{
    //    if (collisionInfo.gameObject.tag == "mur2")
    //    {
    //        Debug.Log("SKIBIDI");
    //        zmianakierunku *= -1;
    //        // transform.collisionInfo.gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();
    //        int losowanie = Random.Range(0, 3);

    //        transform.Rotate(0, 45, 0);
    //        switch (losowanie)
    //        {
    //            case 0:
    //                ww = new Vector3(1, 0, 1);
    //                break;
    //            case 1:
    //                ww = new Vector3(-1, 0, 1);
    //                break;
    //            case 2:
    //                ww = new Vector3(0, 0, 1);
    //                break;
    //        }



    //    }
    //    if (collisionInfo.gameObject.tag == "Gracz")
    //    {
    //        SceneManager.LoadScene("Scena1");
    //    }
    //}
}

