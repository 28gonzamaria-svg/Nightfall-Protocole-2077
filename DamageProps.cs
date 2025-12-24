public class DamageZone : MonoBehaviour
{
    public int damagePerSecond = 10;

    private void OnTriggerStay(Collider other)
    {
        Health playerHealth = other.GetComponent<Health>();
        if(playerHealth != null)
        {
            playerHealth.TakeDamage(damagePerSecond * Time.deltaTime);
        }
    }
}