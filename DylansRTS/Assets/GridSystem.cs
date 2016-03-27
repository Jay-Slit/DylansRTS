using UnityEngine;
using System.Collections;

// New addition
public class GridSystem : MonoBehaviour {

    public float cell_size = 2.0f;

    private float x, z;

	// Use this for initialization
	void Start () {
        x = 0f;
        z = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        x = Mathf.Round(transform.position.x / cell_size) * cell_size;
        z = Mathf.Round(transform.position.z / cell_size) * cell_size;
        transform.position = new Vector3(x, 5, z);
    }
}
