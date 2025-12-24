using UnityEngine;

public class WeaponAdvanced : MonoBehaviour
{
    public string weaponName;
    public float damage = 25f;
    public float range = 100f;
    public float fireRate = 0.2f;
    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    public Killstreak killstreak;

    private float nextTimeToFire = 0f;

    void Update()
    {
        if(Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + fireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        if(muzzleFlash != null)
            muzzleFlash.Play();

        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Enemy enemy = hit.transform.GetComponent<Enemy>();
            if(enemy != null)
            {
                enemy.TakeDamage((int)damage);
                killstreak.AddKill(enemy.gameObject);
            }
        }
    }
}