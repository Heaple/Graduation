using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!Manager.instance.isCleanTownFinish)
        {
            if (collision.gameObject.name == "ClEanSign")
            {
                ClEan.SetActive(true);
            }
        }
        
        if (Manager.instance.isHealthTownFinish && !Manager.instance.isPEFinish)
        {
            if (collision.gameObject.name == "PESign")
            {
                PE.SetActive(true);
            }
        }
        
        if (Manager.instance.isCleanTownFinish && !Manager.instance.isHealthTownFinish)
        {
            if (collision.gameObject.name == "HEalthSign")
            {
                HEalth.SetActive(true);
            }
        }
        
        if (Manager.instance.isPEFinish&& !Manager.instance.isPaperFinish)
        {
            if (collision.gameObject.name == "PapErSign")
            {
                PapEr.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
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

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!Manager.instance.isCleanTownFinish)
        {
            if (collision.gameObject.name == "ClEanSign")
            {
                if (Input.GetKey(KeyCode.E))
                {
                    SceneManager.LoadScene("CleanTown");
                }
            }
        }
        if (Manager.instance.isCleanTownFinish && !Manager.instance.isHealthTownFinish)
        {
            if (collision.gameObject.name == "HEalthSign")
            {
                if (Input.GetKey(KeyCode.E))
                {
                    SceneManager.LoadScene("HealthTown");
                }
            }
        }
        
        if (Manager.instance.isHealthTownFinish && !Manager.instance.isPEFinish)
        {
            if (collision.gameObject.name == "PESign")
            {
                if (Input.GetKey(KeyCode.E))
                {
                    SceneManager.LoadScene("PETown");
                }
            }
        }
        if (Manager.instance.isPEFinish && !Manager.instance.isPaperFinish)
        {
            if (collision.gameObject.name == "PapErSign")
            {
                if (Input.GetKey(KeyCode.E))
                {
                    SceneManager.LoadScene("PaperTown");
                }
            }
        }
        
    }
}
