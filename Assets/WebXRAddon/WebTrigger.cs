using WebXR;
using Zinnia.Action;

public class WebTrigger : BooleanAction
{
    public WebXRController controller;

    // Update is called once per frame
    void Update()
    {
        Receive( controller.GetButton(WebXRController.ButtonTypes.Trigger));
    }
}
