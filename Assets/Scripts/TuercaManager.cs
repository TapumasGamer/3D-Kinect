using UnityEngine;


public class TuercaManager : MonoBehaviour
{
    private bool pausado = false;
    public GameObject TuercaPanel;
    
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
}
