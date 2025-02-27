using UnityEngine;

public class TouchEvents : MonoBehaviour
{
    private Vector2 startTouchPosition;
    private Vector2 endTouchPosition;
    //
    private Vector2 startTouch1Position;
    private Vector2 endTouch1Position;


    // Update is called once per frame
    void Update()
    {
        // Debug.Log(Input.touchCount);

        if(Input.touchCount > 0)
        {
            // ++ Single Touch Gesture++
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
            {
                // +++++++++++++++++++++++++++++++++++
                // +++ Move to Screen X,Y Position +++
                // +++++++++++++++++++++++++++++++++++
                // this.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 5));
                
                // ++++++++++++++++++++++++++++++++++++
                // +++ Move to World X,Y,Z Position +++
                // ++++++++++++++++++++++++++++++++++++
                /*
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;
                if (Physics.Raycast(ray , out hit)){
                    if (hit.collider.tag=="Ground"){
                        this.transform.position = hit.point;
                    }
                }
                */

                // +++++++++++++++++++++++++
                // ++ Swipe Gesture Start ++
                // +++++++++++++++++++++++++
                // startTouchPosition = touch.position;
            }

            /*
            if(touch.phase == TouchPhase.Ended)
            {
                // +++++++++++++++++++++++++++++
                // ++ Swipe Gesture End Check ++ 
                // +++++++++++++++++++++++++++++
                endTouchPosition = touch.position;

                // Check for swipe direction
                if (endTouchPosition.x < startTouchPosition.x)
                {
                    // Swipe Left
                }
                if (endTouchPosition.x > startTouchPosition.x)
                {
                    // Swipe Right
                }

            }
            */

            /*
            // +++++++++++++++++++
            // ++ Pinch Gesture ++
            // +++++++++++++++++++
            // ++ Multi Touch Gesture++
            if (Input.touchCount >= 2)
            {
                Touch touch1 = Input.GetTouch(1);
                if(touch1.phase == TouchPhase.Began)
                {
                    startTouchPosition = touch.position;
                    startTouch1Position = touch1.position;
                }

                if(touch.phase == TouchPhase.Moved)
                {
                    endTouchPosition = touch.position;
                    endTouch1Position = touch1.position;

                    //calc zoom
                    float zoomFactor = Vector3.Distance(endTouchPosition, endTouch1Position) / 
                        Vector3.Distance(startTouchPosition, startTouch1Position);

                    Debug.Log(zoomFactor);
                }
            }
            */
            
        }
    }
}
