using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
public class Puntajes : MonoBehaviour
{
    public Text texto;

    public int Puntaje;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Puntajeador());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Puntajeador()
    {


        yield return new WaitForSeconds(1);
        Puntaje++;



        StartCoroutine(Puntajeador());
        texto.text = "Score: " + Puntaje;



    }
}
