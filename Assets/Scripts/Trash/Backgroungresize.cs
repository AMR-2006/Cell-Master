using UnityEngine;

public class Backgroungresize : MonoBehaviour
{
    public bool isacpectratio;

    private void Start()
    {
        var toorightcorner = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,Camera.main.transform.position.z));
        var worldscreenwight = toorightcorner.x * 2;
        var worldscreenheight = toorightcorner.y * 2;

        var spritesize = this.GetComponent<SpriteRenderer>().bounds.size;

        var scalefactorx = worldscreenwight / spritesize.x;
        var scalefactory = worldscreenheight / spritesize.y;

        if(isacpectratio)
        {
            if(scalefactorx > scalefactory)
            {
                scalefactory = scalefactorx;
            }
            else
            {
                scalefactorx = scalefactory;
            }
        }
        transform.localScale = new Vector3(scalefactorx, -scalefactory, 1);
    }
}
