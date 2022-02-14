using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager
{
    private static Manager Instance;

    public static Manager instance
    {
        get
        {
            if (Instance == null)
                Instance = new Manager();
            return Instance;
        }
    }


    public bool isCleanTownFinish = false;
    public bool isHealthTownFinish = false;
    public bool isPEFinish = false;
    public bool isPaperFinish = false;
}
