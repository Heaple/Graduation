using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanTownNPC : MonoBehaviour
{
    GameObject gunoo_e;
    GameObject jihoo_e;
    GameObject NeedHelp;
    public GameObject JihooCanvas;
    public GameObject GunooCanvas;
    // Start is called before the first frame update
    void Start()
    {
        gunoo_e = GameObject.Find("gunoo_e");
        jihoo_e = GameObject.Find("jihoo_e");
        NeedHelp = GameObject.Find("NeedHelp");
        gunoo_e.SetActive(false);
        jihoo_e.SetActive(false);
        if (CleantownManager.instance.isGameFinished) {
            NeedHelp.transform.position = new Vector3(-5.18f, 0.08f, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!Manager.instance.isCleanTownFinish) {
            if (collision.gameObject.name == "gunoo") {
                if (CleantownManager.instance.isJihooTalk) { 
                    if (!CleantownManager.instance.isGunooTalk || CleantownManager.instance.isGameFinished) {
                        gunoo_e.SetActive(true);
                    }
                }
            }

            if (!CleantownManager.instance.isJihooTalk) {
                if (collision.gameObject.name == "jihoo") {
                    jihoo_e.SetActive(true);
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "gunoo")
        {
            gunoo_e.SetActive(false);
        }
        if (!CleantownManager.instance.isGameFinished)
        {
            if (collision.gameObject.name == "jihoo")
            {
                jihoo_e.SetActive(false);
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!Manager.instance.isCleanTownFinish) {
            if (!CleantownManager.instance.isGameFinished)
            {
                if (collision.gameObject.name == "jihoo")
                {
                    if (!CleantownManager.instance.isJihooTalk)
                    if (Input.GetKey(KeyCode.E))
                    {
                        NeedHelp.transform.position = new Vector3(-5.18f, 0.08f, 0);
                        JihooCanvas.SetActive(true);
                    }
                }
            }
            
            if (collision.gameObject.name == "gunoo")
            {
                if (CleantownManager.instance.isJihooTalk)
                {
                    if (CleantownManager.instance.isGameFinished || !CleantownManager.instance.isGunooTalk) {
                        if (Input.GetKey(KeyCode.E))
                        {
                            NeedHelp.SetActive(false);
                            GunooCanvas.SetActive(true);
                        }
                    }
                }
            }
        }
    }
}
