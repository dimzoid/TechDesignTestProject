using UnityEngine;

public class penguin_slide_script : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();

        if (animator == null)
        {
            Debug.LogError("��������� Animator �� ������ �� �������.");
        }
    }

    private void OnMouseDown()
    {
        animator.SetTrigger("Clicker");
    }
}

