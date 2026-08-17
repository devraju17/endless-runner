using UnityEngine;

public class LevelGenerator : MonoBehaviour

{
    [SerializeField] GameObject ChunkPrefab;
    [SerializeField] int startingChunkAmount = 12;
    [SerializeField] Transform ChunkParent;
    [SerializeField] float ChunkLength = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < startingChunkAmount; i++)
        {
            float spawnPositionZ;
            if(i==0)
            {
                spawnPositionZ = transform.position.z;
            }
            else
            {
                spawnPositionZ = transform.position.z + (i * ChunkLength);
            }
            Vector3 chunkSpawnPos = new Vector3(transform.position.x, transform.position.y, spawnPositionZ);
            Instantiate(ChunkPrefab, chunkSpawnPos, Quaternion.identity,ChunkParent);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

