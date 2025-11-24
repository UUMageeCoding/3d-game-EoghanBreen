using Unity.Mathematics;
using UnityEngine;


public class Portal : MonoBehaviour
{

    public Transform teleporter;
    public GameObject Player;

    Vector3 pos;

    CharacterController characterController;
    Quaternion Quat;



    void Start()
    {

        characterController = GetComponent<CharacterController>();
        teleporter = GetComponent<Transform>();


        void OnTriggerEnter(Collider door)
        {
            if (door.CompareTag("door"))
            {
                teleporter.transform.GetPositionAndRotation(out pos, out Quat);



                characterController.enabled = false;
                Player.transform.position = teleporter.position;
                characterController.enabled = true;
                Debug.Log("teleporter");
            }

        }
    }
}
