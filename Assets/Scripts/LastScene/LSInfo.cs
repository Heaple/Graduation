using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LSInfo : MonoBehaviour
{
    public GameObject albumfir;
    public GameObject albumsec;
    public GameObject justBlack;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            if (LSManager.instance.isFir) {
                albumfir.SetActive(false);
                albumsec.SetActive(true);
                LSManager.instance.isFir = false;
            } else {
                albumsec.SetActive(false);
                justBlack.SetActive(true);
                LSManager.instance.isEnd = true;
                this.gameObject.SetActive(false);
            }
        }
    }
}
