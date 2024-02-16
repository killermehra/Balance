using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CinemachineFreeLook))]
public class NewBehaviourScript : MonoBehaviour
{
    public float lookspeed = 1;
    private CinemachineFreeLook cinemachine;
    private playerinput playerInput;
    private void Awake()
    {
        playerInput = new playerinput();
        cinemachine = GetComponent<CinemachineFreeLook>();
    }
    private void OnEnable()
    {
        playerInput.Enable();
    }
    private void OnDisable()
    {
        playerInput.Disable();
    }
  
    void Update()
    {
        Vector2 delta = playerInput.player.look.ReadValue<Vector2>();
        cinemachine.m_XAxis.Value += delta.x * 100 * lookspeed * Time.deltaTime;
        cinemachine.m_YAxis.Value += delta.y * lookspeed * Time.deltaTime;
    }
}
