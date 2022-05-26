using UnityEngine;

namespace Outward.SkipReadinessCheck
{
    public class MenuChecker : MonoBehaviour
    {
        private void Update()
        {
            if (MenuManager.Instance.IsMasterLoadingDisplayed && !NetworkLevelLoader.Instance.IsGameplayLoading)
            {
                NetworkLevelLoader.Instance.SetContinueAfterLoading();
            }
        }
    }
}
