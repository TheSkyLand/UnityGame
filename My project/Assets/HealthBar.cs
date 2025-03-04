using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public Camera MainCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
  
    }
    private void AlignCamera()
    {
        if (MainCamera != null)
        {
            var camXform = MainCamera.transform;
            var forward = transform.position - camXform.position;
            forward.Normalize();
            var up = Vector3.Cross(forward, camXform.right);
            transform.rotation = Quaternion.LookRotation(forward, up);
        }
    }
}
