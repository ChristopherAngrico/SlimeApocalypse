using UnityEngine;
using UnityEngine.EventSystems;

public class SprayWater : MonoBehaviour
{
    private ParticleSystem waterParticleSystem;
    private new PolygonCollider2D collider;
    private ParticleSystem.EmissionModule em;
    private void Start()
    {
        // init the component
        waterParticleSystem = GetComponent<ParticleSystem>();
        em = waterParticleSystem.emission;
        em.enabled = false;

        collider = GetComponent<PolygonCollider2D>();
        collider.enabled = false;
    }
    private void Update()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            if (Input.GetMouseButton(0))
            {
                collider.enabled = true;
                em.enabled = true;

                Vector3 mousePosition = Input.mousePosition;
                mousePosition.z = Camera.main.nearClipPlane;
                Vector3 convertScreenToWorldSpace = Camera.main.ScreenToWorldPoint(mousePosition);
                Vector2 difference = convertScreenToWorldSpace - transform.position;
                float angle = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(0, 0, angle);
            }
            else
            {
                em.enabled = false;
                collider.enabled = false;
            }
        }
    }


}
