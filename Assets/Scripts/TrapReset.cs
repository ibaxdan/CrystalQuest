using UnityEngine;

public class TrapReset : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Devuelve al jugador a la posición de inicio
            other.transform.position = new Vector3(8.84952f, 0.619857f, -8.915929f);

            // Detiene la inercia o velocidad acumulada para que no siga rodando
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.linearVelocity = Vector3.zero; // Si usas versión antigua, cámbialo a rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }
        }
    }
}