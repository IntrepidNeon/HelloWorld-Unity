using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubething : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cubePrefabVar;
    void Start()
    {
        //Instantiate(cubePrefabVar);
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(cubePrefabVar);
    }
}
