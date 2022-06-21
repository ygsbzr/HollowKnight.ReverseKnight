using UnityEngine;
namespace ReverseKnight
{
    public class KnightListener:MonoBehaviour
    {
        void Update()
        {
            if(!HeroController.instance.cState.touchingWall&& HeroController.instance.cState.facingRight)
            {
                Vector3 scale = HeroController.instance.transform.localScale;
                scale.x = 1f;
                HeroController.instance.transform.localScale = scale;
            }
            else if(!HeroController.instance.cState.touchingWall && !HeroController.instance.cState.facingRight)
            {
                Vector3 scale = HeroController.instance.transform.localScale;
                scale.x = -1f;
                HeroController.instance.transform.localScale = scale;
            }
        }
    }
}
