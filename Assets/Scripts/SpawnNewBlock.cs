using UnityEngine;

public class SpawnNewBlock : MonoBehaviour
{
    [SerializeField] GameObject blockPrefab;
    [SerializeField] Transform spawnPosition;
    [SerializeField] NewBlockAction OnSpawnNewBlock;

    public void SpawnBlock()
    {
        Instantiate(blockPrefab, spawnPosition.position, Quaternion.identity);
        OnSpawnNewBlock.Raise();
    }
}
