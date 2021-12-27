using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTown : MonoBehaviour
{
    GameObject ClEan;
    GameObject PE;
    GameObject HEalth;
    GameObject PapEr;
    // Start is called before the first frame update
    void Start()
    {
        ClEan = GameObject.Find("ClEan");
        PE = GameObject.Find("PE");
        HEalth = GameObject.Find("HEalth");
        PapEr = GameObject.Find("PapEr");
        ClEan.SetActive(false);
        PE.SetActive(false);
        HEalth.SetActive(false);
        PapEr.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "ClEanSign")
        {
            ClEan.SetActive(true);
        }

        if (collision.gameObject.name == "PESign")
        {
            PE.SetActive(true);
        }

        if (collision.gameObject.name == "HEalthSign")
        {
            HEalth.SetActive(true);
        }

        if (collision.gameObject.name == "PapErSign")
        {
            PapEr.SetActive(true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "ClEanSign")
        {
            ClEan.SetActive(false);
        }

        if (collision.gameObject.name == "PESign")
        {
            PE.SetActive(false);
        }
        if (collision.gameObject.name == "HEalthSign")
        {
            HEalth.SetActive(false);
        }
        if (collision.gameObject.name == "PapErSign")
        {
            PapEr.SetActive(false);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "ClEanSign")
        {
            if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("CLEANE");
            }
        }

        if (collision.gameObject.name == "PESign")
        {
            PE.SetActive(false);
        }
        if (collision.gameObject.name == "HEalthSign")
        {
            HEalth.SetActive(false);
        }
        if (collision.gameObject.name == "PapErSign")
        {
            PapEr.SetActive(false);
        }
    }
}
