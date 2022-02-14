using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthTownCollision : MonoBehaviour
{
    GameObject milkE;
    GameObject milkbox;
    GameObject wallE;
    // Start is called before the first frame update
    void Start()
    {
        milkE = GameObject.Find("milkE");
        wallE = GameObject.Find("wallE");
        milkbox = GameObject.Find("milkbox");
        milkE.SetActive(false);
        wallE.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "milkboxes")
        {
            if (HealthTownManager.instance.isPullingMilkbox)
            {
                milkE.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "milkboxes")
        {
            milkE.SetActive(false);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "milkboxes")
        {
            if (Input.GetKey(KeyCode.E))
            {
                HealthTownManager.instance.isPullingMilkbox = false;
                HealthTownManager.instance.isMilkTrashFinish = true;
            }
        }
    }
}
