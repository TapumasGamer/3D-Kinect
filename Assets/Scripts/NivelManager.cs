using UnityEngine;
using UnityEngine.SceneManagement;
public class NivelManager : MonoBehaviour
{
    public void CargarNivel(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
}
