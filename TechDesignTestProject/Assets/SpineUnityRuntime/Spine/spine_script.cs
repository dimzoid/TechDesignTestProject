using Spine.Unity;
using UnityEngine;

namespace Spine.Unity.Examples
{
    public class spine_script : MonoBehaviour
    {
        [SpineAnimation]
        public string idleAnimationName;

        SkeletonAnimation skeletonAnimation;
        Spine.AnimationState spineAnimationState;

        void Start()
        {
            skeletonAnimation = GetComponent<SkeletonAnimation>();
            spineAnimationState = skeletonAnimation.AnimationState;

            // Запустите анимацию idle в режиме зацикливания
            spineAnimationState.SetAnimation(0, idleAnimationName, true);
        }
    }
}

