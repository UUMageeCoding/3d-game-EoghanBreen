using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

        [SerializeField] float xValue = 0f;
        [SerializeField] float yValue = 0.001f;
        [SerializeField] float zValue = 0f;

        void Start()
        {

        }

        void Update()
        {
            float xValue = Input.GetAxis("Horizontal");
            float yValue = 0f;
            float zValue = Input.GetAxis("Vertical");
            transform.Translate(xValue, yValue, zValue);
        }
 }


