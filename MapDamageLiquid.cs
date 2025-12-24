public class LootSpawner : MonoBehaviour
{
    public GameObject[] lootPrefabs;

    public void SpawnLoot(Vector3 position)
    {
        int index = Random.Range(0, lootPrefabs.Length);
        Instantiate(lootPrefabs[index], position, Quaternion.identity);
    }
}