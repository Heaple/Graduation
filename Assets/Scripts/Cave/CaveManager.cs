using System.Collections;
using System.Collections.Generic;

public class CaveManager
{
    private static CaveManager Instance;

    public static CaveManager instance
    {
        get
        {
            if (Instance == null)
                Instance = new CaveManager();
            return Instance;
        } 
    }
    public int talkMod;
    public bool canMove = true;
    public bool isSaw = false;
}
