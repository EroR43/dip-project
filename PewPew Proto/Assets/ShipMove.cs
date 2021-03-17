using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMove : MonoBehaviour
{
    public GameObject playerObj;

    [SerializeField]
    private string horizontalInputName;
    [SerializeField]
    private string verticalInputName;
    [SerializeField]
    private int movementSpeed;
    [SerializeField]
    private float maxTilt;

    private CharacterController charController;

    private void Awake()
    {
        charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (gameObject.GetComponent<PlayerHealth>().GetCurrHealth() != 0)
        //{
            PlayerMovement();
        //}
    }

    void PlayerMovement()
    {
        float horizInput = Input.GetAxis(horizontalInputName);
        float vertInput = Input.GetAxis(verticalInputName);

        Vector3 forwardMovement = transform.forward * vertInput;
        Vector3 rightMovement = transform.right * horizInput;

        charController.Move(Vector3.ClampMagnitude(/*forwardMovement + */rightMovement, 1.0f) * Time.deltaTime * movementSpeed/* * Sprint()*/);
        ShipTilt(rightMovement);
    }

    void ShipTilt(Vector3 tiltDir)
    {
        Quaternion tiltAmnt = Quaternion.Euler(0, 0, -maxTilt * tiltDir.x);
        playerObj.transform.rotation = Quaternion.Slerp(playerObj.transform.rotation, tiltAmnt, 7f * (Time.deltaTime));
    }
}

