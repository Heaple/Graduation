using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CaveEnteranceCollision : MonoBehaviour
{
    GameObject e;
    // Start is called before the first frame update
    void Start()
    {
        e = GameObject.Find("e");
        e.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.name == "Cave") {
            e.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)  {
        if (collision.gameObject.name == "Cave") {
            e.SetActive(false);
        }
    }

    private void OnTriggerStay2D(Collider2D collision) {
        if (collision.gameObject.name == "Cave") {
            if (Input.GetKey(KeyCode.E)) {
                SceneManager.LoadScene("Cave");
            }
        }
    }
}
