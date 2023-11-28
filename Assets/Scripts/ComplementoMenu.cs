using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComplementoMenu : MonoBehaviour
{
    public GameObject JornadaPanel;
    public GameObject InicioPanel;
    public GameObject OpcionesPanel;
    public GameObject PrimariaPanel;
    public GameObject SecundariaPanel;
    
    private void Start()
    {
        InicioPanel.SetActive(true);
        OpcionesPanel.SetActive(false);
        SecundariaPanel.SetActive(false);
        PrimariaPanel.SetActive(false);
        JornadaPanel.SetActive(false);
    }
    public void Jugar()
    {
        JornadaPanel.SetActive(true);
        InicioPanel.SetActive(false);
    }
    public void Salir()
    {
        Application.Quit();
    }
    public void Opciones()
    {
        OpcionesPanel.SetActive(true);
        InicioPanel.SetActive(false);
    }
    public void Primaria()
    {
        JornadaPanel.SetActive(false);
        PrimariaPanel.SetActive(true);
    }
    public void Secundaria()
    {
        JornadaPanel.SetActive(false);
        SecundariaPanel.SetActive(true);
    }
    
}
