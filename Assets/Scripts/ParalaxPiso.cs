using UnityEngine;

public class ParalaxPiso : MonoBehaviour
{

    public float distanciaEnX = 20;
    public float velocidadPiso;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(velocidadPiso * Time.deltaTime,0,0);

        if (transform.position.x <= -distanciaEnX)
        {
            transform.position = new Vector3(distanciaEnX, transform.position.y, 0);
        }

    }
}
