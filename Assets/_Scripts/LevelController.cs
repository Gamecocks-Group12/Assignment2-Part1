using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [Header("World Size")]
    public float tileLength;
    public float tileWidth;
    public List<GameObject> tilePrefabs;
    public List<GameObject> activeTiles;
    public GameObject startTile;

     void Awake()
    {
        //surface = GetComponent<NavMeshSurface>();
        //BuildWorld();
    }

    // Start is called before the first frame update
    void Start()
    {
       // surface.BuildNavMesh();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
