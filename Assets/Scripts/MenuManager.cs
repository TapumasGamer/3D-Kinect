using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void SeleccionarJornada(string nombre)
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

