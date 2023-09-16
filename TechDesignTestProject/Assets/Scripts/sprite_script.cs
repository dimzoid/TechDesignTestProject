using UnityEngine;
using UnityEngine.UI;

public class sprite_script : MonoBehaviour
{
    public Button buttonToDisplay;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D hitCollider = Physics2D.OverlapPoint(mousePosition);

            if (hitCollider != null && hitCollider.gameObject == gameObject)
            {
                buttonToDisplay.gameObject.SetActive(true); 
            }
        }
    }
}
