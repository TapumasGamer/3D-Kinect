using UnityEngine;
using UnityEngine.SceneManagement;
public class NivelManager : MonoBehaviour
{
    public GameObject PreguntasPanel;

    public void CargarNivel(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
    public void EmpezarPreguntas()
    {
        PreguntasPanel.SetActive(true);
    }
}
