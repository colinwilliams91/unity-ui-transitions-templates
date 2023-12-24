using UnityEngine;

public class PanelFader : MonoBehaviour
{
    private string _callbackName;

    public AnimationEvent ANMATION_COMPLETE;

    /// <summary>
    /// Button on UI will invoke FadeOut method (player input)
    /// </summary>
    /// <param name="callbackName">Determines where we are transitioning to</param>
    public void FadeOut(string callbackName)
    {
        this._callbackName = callbackName;
        // this only happens once per scene, so we don't need to store it on the Class
            // "FADE_OUT" argument must match Trigger on Unity Animation (e.g. "FadeOut.anim")
        GetComponent<Animator>().SetTrigger(nameof(Triggers.FADE_OUT));
    }

    // Callback Function I added to FadeOut Event (animation event Keyframe)
    public void OnFadeOutComplete()
    {
        ANMATION_COMPLETE.Invoke(this._callbackName);
    }
}
