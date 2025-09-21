using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPersonaje : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Configuración de Movimiento")]
    public float velocidadMovimiento = 5f;
    public float velocidadRotacion = 200f;
    public float fuerzaSalto = 7f;
    
    private Rigidbody rb;
    private bool puedeSaltar = true;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        MoverPersonaje();

    }
     void MoverPersonaje()
    {
        // Obtener input del teclado
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        
        // Calcular dirección de movimiento
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0f, movimientoVertical);
        movimiento = transform.TransformDirection(movimiento);
        
        // Aplicar movimiento
        if (movimiento.magnitude > 0)
        {
            movimiento.Normalize();
            transform.position += movimiento * velocidadMovimiento * Time.deltaTime;
        }
    }
    
}