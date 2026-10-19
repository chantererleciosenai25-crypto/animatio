using UnityEngine;
using UnityEngine.InputSystem;

public class controleanime : MonoBehaviour
{
    [SerializeField] private InputAction ataque;
    [SerializeField] private Animator animator;

    void OnEnable()
    {
        ataque.Enable();
    }

    void Update()
    {
        if (ataque.WasPerformedThisFrame())
        {
            Debug.Log("Atacando...");
            animator.SetBool("ta_batendo", true);
        }
        else
        {
            animator.SetBool("ta_batendo", false);
        }
    }
}