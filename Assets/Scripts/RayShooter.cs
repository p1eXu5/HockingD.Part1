using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class RayShooter : MonoBehaviour
{
    private Camera _camera;

    // Start is called before the first frame update
    void Start()
    {
        _camera = GetComponent<Camera>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetMouseButtonDown( 0 ) ) 
        {
            Vector3 point = new Vector3(  _camera.pixelWidth / 2.0f, _camera.pixelHeight / 2.0f, 0);
            Ray ray = _camera.ScreenPointToRay( point );
            RaycastHit hit;
            if ( Physics.Raycast( ray, out hit ) ) {
                GameObject hitObject = hit.transform.gameObject;
                ReactiveTarget target = hitObject.GetComponent<ReactiveTarget>();
                if ( target != null ) {
                    Debug.Log("Terget hit");
                    target.ReactToHit();
                }
                else {
                    StartCoroutine( ShereIndicator( hit.point ) );
                }
            }
        }
    }

    private IEnumerator ShereIndicator( Vector3 pos )
    {
        GameObject sphere = GameObject.CreatePrimitive( PrimitiveType.Sphere );
        sphere.transform.position = pos;

        yield return new WaitForSeconds( 1 );

        Destroy( sphere );
    }

    void OnGUI()
    {
        int size = 12;
        float posX = _camera.pixelWidth / 2 - size / 4;
        float posY = _camera.pixelHeight / 2 - size / 4;
        GUI.Label( new Rect( posX, posY, size, size), "*"  );
    }
}
