using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HospitalNPC : MonoBehaviour
{
    public GameObject YeWonCanvas;
    GameObject e;
    GameObject boardE;
    GameObject milkE;
    GameObject milkbox;
    // Start is called before the first frame update
    void Start()
    {
        e = GameObject.Find("e");
        boardE = GameObject.Find("boardE");
        milkE = GameObject.Find("milkE");
        milkbox = GameObject.Find("milkbox");
        milkE.SetActive(false);
        boardE.SetActive(false);
        e.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(HealthTownManager.instance.isPullingMilkbox);
        if (HealthTownManager.instance.isPullingMilkbox)
        {
            milkE.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "YeWon")
        {
            if (!HealthTownManager.instance.isQuestTalkFinish || HealthTownManager.instance.isQuestFinish) {
                if (!Manager.instance.isHealthTownFinish) {
                    e.SetActive(true);
                }
            }
        }

        if (HealthTownManager.instance.isQuestTalkFinish)
        {
            if (collision.gameObject.name == "greenboard")
            {
                if (!HealthTownManager.instance.isBoardCleanFinish)
                {
                    boardE.SetActive(true);
                }
            }

            if (collision.gameObject.name == "milkbox")
            {
                if (!HealthTownManager.instance.isMilkTrashFinish)
                {
                    if (!HealthTownManager.instance.isPullingMilkbox)
                    {
                        milkE.SetActive(true);
                        float milkX = milkbox.transform.position.x;
                        float milkY = milkbox.transform.position.y;
                        milkE.transform.position = new Vector3(milkX += 2, milkY += 1, 0);
                    }
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "YeWon")
        {
            e.SetActive(false);
        }

        if (collision.gameObject.name == "greenboard")
        {
            boardE.SetActive(false);
        }

        if (collision.gameObject.name == "milkbox")
        {
            milkE.SetActive(false);
            float milkX = milkbox.transform.position.x;
            float milkY = milkbox.transform.position.y;
            milkE.transform.position = new Vector3(milkX += 2, milkY += 1, 0);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!HealthTownManager.instance.isQuestTalkFinish || HealthTownManager.instance.isQuestFinish) {
            if (!Manager.instance.isHealthTownFinish) {
                if (collision.gameObject.name == "YeWon") {
                    if (Input.GetKey(KeyCode.E)) {
                        YeWonCanvas.SetActive(true);
                    }
                }
            }
            
        }

        if (HealthTownManager.instance.isQuestTalkFinish)
        {
            if (collision.gameObject.name == "greenboard")
            {
                if (Input.GetKey(KeyCode.E))
                {
                    if (!HealthTownManager.instance.isBoardCleanFinish)
                    {
                        SceneManager.LoadScene("CleanBoard");
                    }
                }
            }

            if (collision.gameObject.name == "milkbox")
            {
                if (!HealthTownManager.instance.isPullingMilkbox)
                {
                    if (Input.GetKey(KeyCode.E))
                    {
                        HealthTownManager.instance.isPullingMilkbox = true;
                    }
                }
            }
        }
    }
}
