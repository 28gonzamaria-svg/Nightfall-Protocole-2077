using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Killstreak killstreak;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }
}