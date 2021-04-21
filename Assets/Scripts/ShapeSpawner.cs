using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSpawner : MonoBehaviour
{
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;

    [SerializeField] List<GameObject> prefabList = new List<GameObject>();


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
        int prefabIndex = Random.Range(0, 2);
        GameObject newShape = Instantiate
            (prefabList[prefabIndex], transform.position, transform.rotation)
            as GameObject;
        newShape.transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
