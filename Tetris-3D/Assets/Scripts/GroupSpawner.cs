using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupSpawner : MonoBehaviour {

    //All given groups
    public GameObject[] groups;
    
    void Start () {
		
	}

    //Spawn the next group
    public GameObject spawnNext()
    {
        int i = Random.Range(0, groups.Length);
        return Instantiate(groups[i], new Vector3(5, 20), Quaternion.identity);
    }
}
