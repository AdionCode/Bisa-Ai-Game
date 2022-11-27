using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereLoops : MonoBehaviour
{
    public GameObject[] sphere;
    [SerializeField] GameObject searchOBJ;
    GameObject[] searchOBJs;

    // Start is called before the first frame update
    void Start()
    {
        searchOBJ = GameObject.Find("Red Sphere");

        foreach (GameObject spheres in sphere)
        {

            //Destroy(spheres, 2f);
            spheres.SetActive(false);
        }

        searchOBJs = GameObject.FindGameObjectsWithTag("Enemy");
        foreach(GameObject s in searchOBJs)
        {
            Destroy(s, 2f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
