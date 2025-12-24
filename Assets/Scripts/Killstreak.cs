using UnityEngine;

public class Killstreak : MonoBehaviour
{
    public int kills = 0;

    public void AddKill()
    {
        kills++;

        if (kills == 5)
        {
            Debug.Log("Killstreak x5");
        }
        else if (kills == 10)
        {
            Debug.Log("Killstreak x10");
        }
        else if (kills == 20)
        {
            Debug.Log("ULTRA KILLSTREAK");
        }
    }
}
