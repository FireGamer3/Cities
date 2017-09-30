using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {
    public GameObject TilePrefab;
    public Material[] TileTerrain;
    void Start () {
        GenerateMap();
	}
	public void GenerateMap() {
        for (int x = 0; x < 10; x++) {
            for (int y = 0; y < 10; y++) {
                Tile t = new Tile(x, y);
                GameObject tileGO = Instantiate(TilePrefab, t.Position(), Quaternion.identity, this.transform);
                MeshRenderer mr = tileGO.GetComponentInChildren<MeshRenderer>();
                mr.material = TileTerrain[Random.Range(0, TileTerrain.Length)];
            }
        }
    }
}
