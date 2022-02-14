using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EraseBoard : MonoBehaviour
{
    GameObject six;
    GameObject hyphen;
    GameObject eight;
    public GameObject Canvas;
    // Start is called before the first frame update
    void Start()
    {
        SetResolution();
        six = GameObject.Find("6");
        hyphen = GameObject.Find("-");
        eight = GameObject.Find("8");
    }

    // Update is called once per frame
    void Update()
    {
        if (six.GetComponent<SpriteRenderer>().color.a <= 0 && hyphen.GetComponent<SpriteRenderer>().color.a <= 0 && eight.GetComponent<SpriteRenderer>().color.a <= 0)
        {
            Canvas.SetActive(true);
            Invoke("ChangeToHospital", 3.0f);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (Input.GetMouseButtonDown(0))
        {
            SpriteRenderer spr = collision.GetComponent<SpriteRenderer>();
            Color color = spr.color;
            Debug.Log(color.a);
            color.a = color.a - 0.1f;
            spr.color = color;
        }
    }

    void ChangeToHospital()
    {
        SceneManager.LoadScene("Hospital");
        HealthTownManager.instance.isBoardCleanFinish = true;
    }

    public void SetResolution()
    {
        int setWidth = 1920;
        int setHeight = 1080;

        int deviceWidth = Screen.width;
        int deviceHeight = Screen.height;
        
        Screen.SetResolution(setWidth, (int)(((float)deviceHeight / deviceWidth) * setWidth), true);

        if ((float)setWidth / setHeight < (float)deviceWidth / deviceHeight)
        {
            float newWidth = ((float)setWidth / setHeight) / ((float)deviceWidth / deviceHeight);
            Camera.main.rect = new Rect((1f - newWidth) / 2f, 0f, newWidth, 1f);
        }
        else
        {
            float newHeight = ((float)deviceWidth / deviceHeight) / ((float)setWidth / setHeight);
            Camera.main.rect = new Rect(0f, (1f - newHeight) / 2f, 1f, newHeight);
        }
    }
}
