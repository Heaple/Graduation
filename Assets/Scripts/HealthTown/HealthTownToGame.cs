using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthTownToGame : MonoBehaviour
{
    public GameObject e;
    // Start is called before the first frame update
    void Start()
    {
        e.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "DoorStep")
        {
            if (!HealthTownManager.instance.isPullingMilkbox) {
                e.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "DoorStep")
        {
            e.SetActive(false);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "DoorStep")
        {
            if (Input.GetKey(KeyCode.E))
            {
                if (!HealthTownManager.instance.isPullingMilkbox) {
                    HealthTownManager.instance.isPlayerEntered = true;
                    SceneManager.LoadScene("Hospital");
                }
            }
        }
    }
}
