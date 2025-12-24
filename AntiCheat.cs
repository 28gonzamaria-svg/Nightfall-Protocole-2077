using UnityEngine;

public class AntiCheat : MonoBehaviour
{
    public float maxSpeed = 10f; // Velocidad máxima permitida
    public GameObject player;

    void Update()
    {
        CheckSpeed();
    }

    void CheckSpeed()
    {
        if(player.GetComponent<Rigidbody>() != null)
        {
            float speed = player.GetComponent<Rigidbody>().velocity.magnitude;
            if(speed > maxSpeed)
            {
                TriggerBan("Speed hack detectado!");
            }
        }
    }

    public void TriggerBan(string reason)
    {
        Debug.Log("🚨 BAN: " + reason);
        // Aquí podemos poner una animación o pantalla de advertencia
        // y luego quitar el jugador del juego
        player.SetActive(false);
        // Opcional: guardar log en servidor o local
    }
}
