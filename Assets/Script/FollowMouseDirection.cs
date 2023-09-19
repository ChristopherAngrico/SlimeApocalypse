using UnityEngine;
public class FollowMouseDirection : MonoBehaviour
{
    [HideInInspector] public Vector2 difference;
    public bool isSword;
    private void Update()
    {
        InputMouseDirection();
    }
    private void InputMouseDirection()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = Camera.main.nearClipPlane;
        Vector3 convertScreenToWorldSpace = Camera.main.ScreenToWorldPoint(mousePosition);
        difference = convertScreenToWorldSpace - transform.position;
        int freezeRotation = 0;
        if (Time.timeScale == 0)
        {
            freezeRotation = 0;
        }else{
            freezeRotation = 1;
        }
        float angle = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg * freezeRotation;

        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        if (isSword)
        {
            float localEuler = 0;
            if (angle > 90 || angle < -90)
            {
                localEuler = -1;
            }
            else
            {
                localEuler = 1;
            }
            transform.localScale = new Vector3(1, localEuler, 1);
        }

    }
}
