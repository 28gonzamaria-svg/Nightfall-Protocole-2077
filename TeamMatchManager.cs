using UnityEngine;
using System.Collections.Generic;

public class TeamMatchManager : MonoBehaviour
{
    public List<GameObject> redTeam;
    public List<GameObject> blueTeam;

    public int redScore = 0;
    public int blueScore = 0;

    public int maxScore = 50; // Gana el equipo que llegue primero

    public void AddKill(GameObject killer)
    {
        // Detectar equipo del killer
        if (redTeam.Contains(killer))
        {
            redScore++;
        }
        else if (blueTeam.Contains(killer))
        {
            blueScore++;
        }

        CheckWin();
    }

    void CheckWin()
    {
        if (redScore >= maxScore)
        {
            Debug.Log("🔴 Equipo Rojo gana!");
        }
        else if (blueScore >= maxScore)
        {
            Debug.Log("🔵 Equipo Azul gana!");
        }
    }
}