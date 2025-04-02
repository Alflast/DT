using UnityEngine;

public class AJC : MonoBehaviour
   {
       public float jumpForce = 5f; // Сила прыжка
       private Rigidbody rb;

       void Start()
       {
           rb = GetComponent<Rigidbody>();
       }

       void OnCollisionEnter(Collision collision)
       {
           // Если куб коснулся земли (или любого другого объекта)
           if (collision.gameObject.CompareTag("Ground"))
           {
               // Прыжок вверх
               rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
           }
       }
   }

