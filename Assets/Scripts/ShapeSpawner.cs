using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSpawner : MonoBehaviour
{
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    [SerializeField] SquarePlayer squarePrefab;
    [SerializeField] EnemyTile enemyPrefab;


    bool spawn = true;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnShapes();
        }    
    }

    private void SpawnShapes()
    {
        SquarePlayer newSquare = Instantiate
            (squarePrefab, transform.position, transform.rotation)
            as SquarePlayer;
        newSquare.transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
