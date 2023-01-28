using System.Collections.Generic;
using UnityEngine;

namespace CodeLibrary24.MissionSystem
{
    [CreateAssetMenu(menuName = "Create Mission", fileName = "Mission", order = 0)]
    public class Mission : ScriptableObject
    {
        public string missionName;
        public string description;
        public List<Mission> subMissions;
    }
}
