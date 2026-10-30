using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{

    public void Resetear()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
