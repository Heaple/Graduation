using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveCollision : MonoBehaviour
{
    GameObject boonpeel;
    GameObject boonpill;
    public GameObject boonpillbackground;
    public GameObject talkCavas;
    // Start is called before the first frame update
    void Start()
    {
        boonpeel = GameObject.Find("boonpeel");
        boonpill = GameObject.Find("boonpill");
        boonpeel.SetActive(false);
        CaveManager.instance.talkMod = 0;
        talkCavas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collsion) {
        if (collsion.gameObject.name == "boonpill") {
            if (!CaveManager.instance.isSaw) {
                boonpeel.SetActive(true);
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision) {
        if (collision.gameObject.name == "boonpill") {
            boonpeel.SetActive(false);
        }
    }

    void OnTriggerStay2D(Collider2D collision) {
        if (collision.gameObject.name == "boonpill") {
            if (!CaveManager.instance.isSaw) {
                if (Input.GetKey(KeyCode.E)) {
                    boonpillbackground.SetActive(true);
                    CaveManager.instance.talkMod = 1;
                    talkCavas.SetActive(true);
                }
            }
            
        }
    }
}
