using UnityEngine;

public class WeaponFireParticles : MonoBehaviour
{
    public ParticleSystem fireParticles;

    public void Shoot()
    {
        if(fireParticles != null)
            fireParticles.Play();
    }
}