using UnityEngine;
using UnityEngine.SceneManagement;

public class MaanagerCopy : MonoBehaviour
{
    public void CargarNivel(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
    public void Salir()
    {
        Application.Quit();
    }
    public void Opciones(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
}
