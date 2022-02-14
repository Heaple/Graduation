using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CleanGame : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject trashCanvas;
    public TextMeshProUGUI trashText;
    public GameObject trashe;
    public GameObject trashcane;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (CleantownManager.instance.trashCount == 7 && CleantownManager.instance.trashMax == 0) {
            CleantownManager.instance.isGameFinished = true;
        }
        Debug.Log(CleantownManager.instance.isGameFinished);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "trash")
        {
            trashe.SetActive(true);
            Debug.Log("HI");
            trashe.transform.position = new Vector3(collision.transform.position.x + 1f, collision.transform.position.y, 0);
        }

        if (collision.gameObject.name == "trashcan")
        {
            if (CleantownManager.instance.trashMax != 0)
            {
                trashcane.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "trash")
        {
            trashe.SetActive(false);
        }

        if (collision.gameObject.name == "trashcan") {
            trashcane.SetActive(false);
        }
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "trash")
        {
            if (Input.GetKey(KeyCode.E))
            {
                if (CleantownManager.instance.trashMax == 5) {
                    trashCanvas.SetActive(true);
                    trashText.text = "주머니가 다 차버려서 못줍겠다...";
                }
                else
                {
                    Destroy(collision.gameObject);
                    CleantownManager.instance.trashMax++;
                    CleantownManager.instance.trashCount++;
                }
            }
        }

        if (collision.gameObject.name == "trashcan")
        {
            if (Input.GetKey(KeyCode.E))
            {
                if (CleantownManager.instance.trashMax != 0)
                {
                    CleantownManager.instance.trashMax = 0;
                    CleantownManager.instance.isTryGoOutInTrashGame = true;
                    trashCanvas.SetActive(true);
                    trashText.text = "이제 좀 몸이 가볍네.";
                }
                
            }
        }
    }
}
