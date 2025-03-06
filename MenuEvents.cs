using UnityEngine;

public class MenuEvents : MonoBehaviour
{
    private Vector2 startTouchPosition;
    private Vector2 endTouchPosition;
    //
    private Vector2 startTouch1Position;
    private Vector2 endTouch1Position;

    // 
    public GameObject[] menuScreens;
    public int menuScreenNumber = 0;

    public void SelectMenuScreen(int screenNum){

        // Hide All Screens
        for (int i=0;i<menuScreens.Length;i++){
            menuScreens[i].SetActive(false);
        }
        // Show Selected Screen
        menuScreens[screenNum].SetActive(true);

    }

    void Start(){
        SelectMenuScreen(menuScreenNumber);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(Input.touchCount);

        if(Input.touchCount > 0)
        {
            // ++ Single Touch Gesture++
            Touch touch = Input.GetTouch(0); // first touch
            if(touch.phase == TouchPhase.Began)
            {
                // +++++++++++++++++++++++++
                // ++ Swipe Gesture Start ++
                // +++++++++++++++++++++++++
                startTouchPosition = touch.position;
            }
            
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
                    Debug.Log("SWIPE LEFT");
                    menuScreenNumber++;
                    if (menuScreenNumber>menuScreens.Length-1){
                        menuScreenNumber=menuScreens.Length-1;
                    }
                    SelectMenuScreen(menuScreenNumber);
                }
                if (endTouchPosition.x > startTouchPosition.x)
                {
                    // Swipe Right
                    Debug.Log("SWIPE RIGHT");
                    menuScreenNumber--;
                    if (menuScreenNumber<0){
                        menuScreenNumber=0;
                    }
                    SelectMenuScreen(menuScreenNumber);  
                }

            }
            
            
        }
    }
}