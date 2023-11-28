using UnityEngine;


public class TuercaManager : MonoBehaviour
{
    private bool pausado = false;
    public GameObject TuercaPanel;
    public GameObject OpcionesPanel;
    public GameObject MusicaPanel;
    public GameObject RecursosPanel;

    private void Start()
    {
        TuercaPanel.SetActive(false);
        OpcionesPanel.SetActive(false);
        MusicaPanel.SetActive(false);
        RecursosPanel.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausado)
                ContinuarJuego();
            else
                PausarJuego();
        }
    }
    public void PausarJuego()
    {
        TuercaPanel.SetActive(true);
        pausado = true;
    }
    public void ContinuarJuego()
    {
        TuercaPanel.SetActive(false);
        pausado= false;
    }
    public void Opciones()
    {
        OpcionesPanel.SetActive(true);
        TuercaPanel.SetActive(false);
        pausado = true;
    }
    public void Volver()
    {
        OpcionesPanel.SetActive(false);
        TuercaPanel.SetActive(true);
    }
    public void Salir()
    {
        Application.Quit();
        Debug.Log("Saliendo de la Aplicación");
    }
}
