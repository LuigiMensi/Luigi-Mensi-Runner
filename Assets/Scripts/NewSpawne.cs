using UnityEngine;
using System.Collections;
public class NewSpawne : MonoBehaviour
{

    public GameObject enemigoPrefab0;
    public GameObject enemigoPrefab1;
    public GameObject enemigoPrefab2;
    public Transform spawnpoint;

    private int numerorandom; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Spawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawner()
    {

        creacion();
        yield return new WaitForSeconds(2);

        numerorandom = Random.Range(0, 3);
        

        StartCoroutine(Spawner());


    }

    private void creacion()
    {

        if (numerorandom == 0)
        {
            Instantiate(enemigoPrefab0, spawnpoint.position, Quaternion.identity);
        }
        else if (numerorandom == 1)
        {
            Instantiate(enemigoPrefab1, spawnpoint.position, Quaternion.identity);
        }
        else 
        {
            Instantiate(enemigoPrefab2, spawnpoint.position, Quaternion.identity);
        }


    }

}
