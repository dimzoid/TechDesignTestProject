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

            // ��������� �������� idle � ������ ������������
            spineAnimationState.SetAnimation(0, idleAnimationName, true);
        }
    }
}

