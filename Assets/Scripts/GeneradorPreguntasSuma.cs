using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GeneradorPreguntasSuma : MonoBehaviour
{
    public TextMeshProUGUI preguntaText;
    public InputField respuestaInput;
    public GameObject PreguntasPanel;

    private int num1;
    private int num2;
    private int respuestaCorrecta;

    void Start()
    {
        GenerarPregunta();
        PreguntasPanel.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            ComprobarRespuesta();
        }
    }
    public void ComprobarRespuesta()
    {
        int respuestaUsuario;
        bool esNumero = int.TryParse(respuestaInput.text, out respuestaUsuario);

        if (esNumero)
        {
            if (respuestaUsuario == respuestaCorrecta)
            {
                Debug.Log("¡Correcto!");
                GenerarPregunta();
            }
            else
            {
                Debug.Log("¡Incorrecto! Inténtalo de nuevo.");
            }
            respuestaInput.text = ""; // Limpiar el campo de respuesta después de la verificación
        }
    }
    void GenerarPregunta()
    {
        num1 = Random.Range(1, 10);
        num2 = Random.Range(1, 10);

        respuestaCorrecta = num1 + num2;

        preguntaText.text = "¿Cuánto es " + num1 + " + " + num2 + "?";
        respuestaInput.text = "";
    }
    public void EmpezarPreguntas()
    {
        PreguntasPanel.SetActive(true);
    }
}
