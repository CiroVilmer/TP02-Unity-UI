using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContrasenia : MonoBehaviour
{
    string contraseniaCorrecta;
    string contraseniaUsuario;
    public Text ingresoUsuario;
    public GameObject cartelitoMsj;
    public Text textoMsj;

    void Start()
    {
        contraseniaCorrecta = "12345";
        cartelitoMsj.SetActive(false);
    }

    public void validarContrasenia()
    {
        contraseniaUsuario = ingresoUsuario.text;
        if (contraseniaUsuario == contraseniaCorrecta)
        {
            textoMsj.text = "Bienvenido";
            cartelitoMsj.SetActive(true);
            Debug.Log("Bienvenido");
        }
        else
        {
            textoMsj.text = "Contraseña Incorrecta";
            cartelitoMsj.SetActive(true);
            Debug.Log("Contrasenia Incorrecta");
        }
    }
}
