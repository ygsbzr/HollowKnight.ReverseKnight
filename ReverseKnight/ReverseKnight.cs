using Modding;
using System.Reflection;
using UnityEngine;
namespace ReverseKnight
{
    public class ReverseKnight:Mod
    {
        public override string GetVersion()
        {
            return "1.0";
        }
        public override void Initialize()
        {
            On.HeroController.Start += AddListener;
        }

        private void AddListener(On.HeroController.orig_Start orig, HeroController self)
        {
            orig(self);
            if(self.gameObject.GetComponent<KnightListener>()==null)
            {
                self.gameObject.AddComponent<KnightListener>();
            }
        }
    }
}
