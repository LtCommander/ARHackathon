using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InvisibleQuadBehavior : MonoBehaviour {

    [SerializeField]
    private GameObject sphereToSpawn;
    [SerializeField]
    private GameObject textToSpawn;

    private GameObject textSpawn;
    
    // Use this for initialization
    void Start()
    {

    }

    // Called by GazeGestureManager when the user performs a Select gesture
    void OnSelect()
    {
       // GameObject newSphere = Instantiate(sphereToSpawn, this.transform.position, this.transform.rotation) as GameObject;
    }

    public Text SpawnWordObject()
    {
        textSpawn = Instantiate(textToSpawn, this.transform.position, this.transform.rotation) as GameObject;
        textSpawn.transform.SetParent(this.transform);

        return textSpawn.GetComponentInChildren<Text>();
    }

    public void ReleaseWordObject()
    {
        textSpawn.transform.SetParent(null);
    }


}
