using UnityEngine;
using UnityEngine.UI;

public class KillstreakUI : MonoBehaviour
{
    public Text killText;
    public Killstreak killstreak;

    void Update()
    {
        killText.text = "Kills: " + killstreak.kills;
    }
}