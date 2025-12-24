public Transform[] spawnPoints;

public void SpawnPlayer(GameObject player)
{
    int index = Random.Range(0, spawnPoints.Length);
    player.transform.position = spawnPoints[index].position;
    player.transform.rotation = spawnPoints[index].rotation;
}