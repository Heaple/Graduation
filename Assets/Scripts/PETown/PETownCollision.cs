using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PETownCollision : MonoBehaviour
{
    GameObject haonE;
    GameObject doorE;
    public GameObject haonCanvas;
    // Start is called before the first frame update
    void Start()
    {
        haonE = GameObject.Find("haonE");
        doorE = GameObject.Find("doorE");
        haonE.SetActive(false);
        doorE.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "haon")
        {
            if (PETownManager.instance.isGaveMap == false)
            {
                haonE.SetActive(true);
            }
        }

        if (collision.gameObject.name == "enterance")
        {
            if (PETownManager.instance.isGaveMap)
            {
                doorE.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "haon")
        {
            if (PETownManager.instance.isGaveMap == false)
            {
                haonE.SetActive(false);
            }
        }
        if (collision.gameObject.name == "enterance")
        {
            if (PETownManager.instance.isGaveMap)
            {
                doorE.SetActive(false);
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "haon")
        {
            if (PETownManager.instance.isGaveMap == false)
            {
                if (Input.GetKey(KeyCode.E))
                {
                    haonE.SetActive(false);
                    haonCanvas.SetActive(true);
                }
            }
        }
        if (collision.gameObject.name == "enterance")
        {
            if (PETownManager.instance.isGaveMap)
            {
                if (Input.GetKey(KeyCode.E))
                {
                    SceneManager.LoadScene("SelectTown");
                }
            }
        }
    }
}
