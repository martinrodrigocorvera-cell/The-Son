using UnityEngine;

public class ApuntarACamara : MonoBehaviour
{
    public Camera camara;
    public bool suavizarRotacion = true;
    public float velocidadSuavizado = 5f;
    public float adapt = 1f;

    void Start()
    {
        if (camara == null)
            camara = Camera.main;
    }

    void Update()
    {
        Vector3 direccion = camara.transform.forward;

        if (direccion != Vector3.zero)
        {
            Vector3 direccionHorizontal = new Vector3(direccion.x, 0, direccion.z).normalized;
            float anguloX = (Mathf.Asin(direccion.y) * Mathf.Rad2Deg / 10f) * adapt;

            Quaternion rotacionHorizontal = Quaternion.LookRotation(direccionHorizontal);
            Quaternion rotacionFinal = rotacionHorizontal * Quaternion.Euler(-anguloX * 2, 0, 0);

            if (suavizarRotacion)
                transform.rotation = Quaternion.Slerp(transform.rotation, rotacionFinal, Time.deltaTime * velocidadSuavizado);
            else
                transform.rotation = rotacionFinal;
        }
    }
}
