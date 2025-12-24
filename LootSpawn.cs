using UnityEngine;

public class MapManager : MonoBehaviour
{
    public Transform[] playerSpawns;
    public Transform[] enemySpawns;
    public GameObject[] lootPrefabs;
    public GameObject[] damageZones;

    void Start()
    {
        SpawnPlayers();
        SpawnEnemies();
        SpawnLoot();
    }

    void SpawnPlayers()
    {
        foreach(GameObject player in GameObject.FindGameObjectsWithTag("Player"))
        {
            int index = Random.Range(0, playerSpawns.Length);
            player.transform.position = playerSpawns[index].position;
            player.transform.rotation = playerSpawns[index].rotation;
        }
    }

    void SpawnEnemies()
    {
        foreach(Transform spawnPoint in enemySpawns)
        {
            // Instancia enemigos según el prefab
            // Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }

    void SpawnLoot()
    {
        foreach(Transform spawnPoint in GameObject.FindGameObjectsWithTag("LootSpawn"))
        {
            int index = Random.Range(0, lootPrefabs.Length);
            Instantiate(lootPrefabs[index], spawnPoint.position, Quaternion.identity);
        }
    }

    public void ActivateDamageZones()
    {
        foreach(GameObject zone in damageZones)
        {
            zone.SetActive(true);
        }
    }
}
